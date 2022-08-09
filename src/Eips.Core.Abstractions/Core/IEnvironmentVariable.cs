using System;
using System.Collections.Generic;

/* *************************************************************************************************************************************** *\
* COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
* LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips
{
    /// <summary> 定义了访问环境变量信息的接口。 </summary>
    public interface IEnvironmentVariable
    {
        /// <summary>
        /// 指定名称环境变量值 <see cref="Value" /> 是否不等于 <c> null </c> 和 <see cref="string.Empty" />。
        /// </summary>
        /// <value>
        /// 获取一个值，用于表示指定名称环境变量值 <see cref="Value" /> 是否不等于 <c> null </c> 和 <see cref="string.Empty" />。
        /// </value>
        bool HasValue { get; }

        /// <summary> 环境变量名称。 </summary>
        /// <value> 获取一个字符串，用于表示环境变量名称。 </value>
        string Name { get; }

        /// <summary> 目标环境变量所在位置。 </summary>
        /// <value>
        /// 获取一个值，用于表示目标环境变量所在位置。
        /// <para> 可为空的 <see cref="EnvironmentVariableTarget" /> 类型的值。 </para>
        /// </value>
        /// <seealso cref="EnvironmentVariableTarget" />
        EnvironmentVariableTarget? Target { get; }

        /// <summary> 环境变量值。 </summary>
        /// <value> 获取一个字符串，用于表示环境变量值。 </value>
        string Value { get; }

        /// <summary> 不同位置的环境变量值。 </summary>
        /// <value> 获取 <see cref="IDictionary{TKey, TValue}" /> 类型的对象实例，用于表示不同位置的环境变量值。 </value>
        /// <seealso cref="IDictionary{TKey, TValue}" />
        /// <seealso cref="EnvironmentVariableTarget" />
        IDictionary<EnvironmentVariableTarget, string> Values { get; }
    }
}