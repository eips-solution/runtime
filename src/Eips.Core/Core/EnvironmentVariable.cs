/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Globalization;
using System;
using System.Collections.Generic;

namespace Niacomsoft.Eips
{
    /// <summary>
    /// 提供了访问环境变量信息相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IEnvironmentVariable" />
    public sealed class EnvironmentVariable : IEnvironmentVariable
    {
        /// <summary> 用于初始化一个 <see cref="Environment" /> 类型的对象实例。 </summary>
        /// <param name="envVarName"> 环境变量名称。 </param>
        /// <param name="value"></param>
        /// <param name="target"></param>
        /// <param name="values"></param>
        /// <exception cref="ArgumentException">
        /// 当 <paramref name="envVarName" /> 等于 <c> null </c>、
        /// <see cref="string.Empty" /> 或空格符时，将引发此类型的异常。
        /// </exception>
        internal EnvironmentVariable(string envVarName,
                                     string value = null,
                                     EnvironmentVariableTarget? target = null,
                                     IDictionary<EnvironmentVariableTarget, string> values = null)
        {
            if (StringEqualityComparer.Empty(envVarName))
            {
                throw new ArgumentException(SR.Format("ArgumentException_empty_or_whitespace", nameof(envVarName)), nameof(envVarName));
            }

            Name = envVarName;
            Target = target;
            Value = value;
            Values = values;
        }

        /// <summary>
        /// 指定名称环境变量值
        /// <see cref="P:Niacomsoft.Eips.IEnvironmentVariable.Value" /> 是否不等于
        /// <c> null </c> 和 <see cref="F:System.String.Empty" />。
        /// </summary>
        /// <value>
        /// 获取一个值，用于表示指定名称环境变量值
        /// <see cref="P:Niacomsoft.Eips.IEnvironmentVariable.Value" /> 是否不等于
        /// <c> null </c> 和 <see cref="F:System.String.Empty" />。
        /// </value>
        public bool HasValue => !StringEqualityComparer.Empty(Value, EmptyCompareOptions.OnlyEmpty);

        /// <summary> 环境变量名称。 </summary>
        /// <value> 获取一个字符串，用于表示环境变量名称。 </value>
        public string Name { get; }

        /// <summary> 目标环境变量所在位置。 </summary>
        /// <value>
        /// 获取一个值，用于表示目标环境变量所在位置。
        /// <para> 可为空的 <see cref="EnvironmentVariableTarget" /> 类型的值。 </para>
        /// </value>
        /// <seealso cref="EnvironmentVariableTarget" />
        public EnvironmentVariableTarget? Target { get; }

        /// <summary> 环境变量值。 </summary>
        /// <value> 获取一个字符串，用于表示环境变量值。 </value>
        public string Value { get; }

        /// <summary> 不同位置的环境变量值。 </summary>
        /// <value> 获取 <see cref="IDictionary{TKey, TValue}" /> 类型的对象实例，用于表示不同位置的环境变量值。 </value>
        /// <seealso cref="IDictionary{TKey, TValue}" />
        /// <seealso cref="EnvironmentVariableTarget" />
        public IDictionary<EnvironmentVariableTarget, string> Values { get; }
    }
}