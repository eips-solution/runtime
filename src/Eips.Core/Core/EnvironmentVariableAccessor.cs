/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Globalization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Niacomsoft.Eips
{
    /// <summary> 提供了访问环境变量信息相关的方法。 </summary>
    /// <seealso cref="IEnvironmentVariableAccessor" />
    /// <seealso cref="IAsyncEnvironmentVariableAccessor" />
#if !NET40
    public class EnvironmentVariableAccessor : IAsyncEnvironmentVariableAccessor, IEnvironmentVariableAccessor
#else

    public class EnvironmentVariableAccessor : IEnvironmentVariableAccessor
#endif
    {
        /// <summary> 创建环境变量元祖。 </summary>
        /// <param name="envVarValue"> 环境变量值。 </param>
        /// <param name="target">
        /// 环境变量位置。
        /// <para> <see cref="EnvironmentVariableTarget" /> 类型的值。 </para>
        /// </param>
        /// <returns>
        /// 包含了可为空的 <see cref="EnvironmentVariableTarget" /> 类型、字符串的
        /// <see cref="Tuple{T1, T2}" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="EnvironmentVariableTarget" />
        /// <seealso cref="Tuple{T1, T2}" />
        protected virtual Tuple<EnvironmentVariableTarget?, string> CreateEnvironmentVariableTuple(string envVarValue,
                                                                                                   EnvironmentVariableTarget target)
        {
            if (StringEqualityComparer.Empty(envVarValue, EmptyCompareOptions.OnlyEmpty))
                return new Tuple<EnvironmentVariableTarget?, string>(null, null);
            return new Tuple<EnvironmentVariableTarget?, string>(target, envVarValue);
        }

        /// <summary> 获取系统级环境变量。 </summary>
        /// <param name="name"> 环境变量名称。 </param>
        /// <returns>
        /// 包含了可为空的 <see cref="EnvironmentVariableTarget" /> 类型、字符串的
        /// <see cref="Tuple{T1, T2}" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="EnvironmentVariableTarget" />
        /// <seealso cref="Tuple{T1, T2}" />
        /// <exception cref="System.Security.SecurityException">
        /// 当调用
        /// <see cref="Environment.GetEnvironmentVariable(string, EnvironmentVariableTarget)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        protected virtual Tuple<EnvironmentVariableTarget?, string> GetMachineScopedEnvironmentVariable(string name)
            => CreateEnvironmentVariableTuple(Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.Machine),
                                              EnvironmentVariableTarget.Machine);

        /// <summary> 获取进程级环境变量。 </summary>
        /// <param name="name"> 环境变量名称。 </param>
        /// <returns>
        /// 包含了可为空的 <see cref="EnvironmentVariableTarget" /> 类型、字符串的
        /// <see cref="Tuple{T1, T2}" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="EnvironmentVariableTarget" />
        /// <seealso cref="Tuple{T1, T2}" />
        /// <exception cref="System.Security.SecurityException">
        /// 当调用
        /// <see cref="Environment.GetEnvironmentVariable(string, EnvironmentVariableTarget)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        protected virtual Tuple<EnvironmentVariableTarget?, string> GetProcessScopedEnvironmentVariable(string name)
            => CreateEnvironmentVariableTuple(Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.Process),
                                              EnvironmentVariableTarget.Process);

        /// <summary> 获取用户级环境变量。 </summary>
        /// <param name="name"> 环境变量名称。 </param>
        /// <returns>
        /// 包含了可为空的 <see cref="EnvironmentVariableTarget" /> 类型、字符串的
        /// <see cref="Tuple{T1, T2}" /> 类型的对象实例。
        /// </returns>
        /// <seealso cref="EnvironmentVariableTarget" />
        /// <seealso cref="Tuple{T1, T2}" />
        /// <exception cref="System.Security.SecurityException">
        /// 当调用
        /// <see cref="Environment.GetEnvironmentVariable(string, EnvironmentVariableTarget)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        protected virtual Tuple<EnvironmentVariableTarget?, string> GetUserScopedEnvironmentVariable(string name)
            => CreateEnvironmentVariableTuple(Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.User),
                                              EnvironmentVariableTarget.User);

        /// <summary> 获取指定名称的环境变量信息。 </summary>
        /// <param name="name"> 环境变量名称。 </param>
        /// <returns>
        /// 环境变量信息。
        /// <para> 实现了 <see cref="IEnvironmentVariable" /> 类型接口的对象实例。 </para>
        /// </returns>
        /// <seealso cref="IEnvironmentVariable" />
        /// <exception cref="ArgumentException">
        /// 当 <paramref name="name" /> 等于 <c> null </c>、或者
        /// <see cref="string.Empty" /> 时，将引发此类型的异常。
        /// </exception>
        public IEnvironmentVariable GetEnvironmentVariable(string name)
        {
            if (StringEqualityComparer.Empty(name, EmptyCompareOptions.OnlyEmpty))
            {
                throw new ArgumentException(SR.Format("ArgumentException_empty_or_whitespace", nameof(name)), nameof(name));
            }

            var processEnv = GetProcessScopedEnvironmentVariable(name);
            var userEnv = GetUserScopedEnvironmentVariable(name);
            var machineEnv = GetMachineScopedEnvironmentVariable(name);

            var values = new Dictionary<EnvironmentVariableTarget, string>
            {
                { EnvironmentVariableTarget.Process, processEnv.Item2 },
                { EnvironmentVariableTarget.User, userEnv.Item2 },
                { EnvironmentVariableTarget.Machine, userEnv.Item2 }
            };

            var target = processEnv.Item1;
            var env = processEnv.Item2;
            if (StringEqualityComparer.Empty(env, EmptyCompareOptions.OnlyEmpty))
            {
                target = userEnv.Item1;
                env = userEnv.Item2;
                if (StringEqualityComparer.Empty(env, EmptyCompareOptions.OnlyEmpty))
                {
                    target = machineEnv.Item1;
                    env = machineEnv.Item2;
                }
            }
            return new EnvironmentVariable(name, env, target, values);
        }

#if !NET40
        /// <summary> (异步的方法) 获取指定名称的环境变量。 </summary>
        /// <param name="name"> 环境变量名称。 </param>
        /// <returns> 环境变量信息。 </returns>
        /// <seealso cref="IEnvironmentVariable" />
        /// <seealso cref="Task{TResult}" />
        public Task<IEnvironmentVariable> GetEnvironmentVariableAsync(string name)
        {
            return Task.Run(() => GetEnvironmentVariable(name));
        }
#endif
    }
}