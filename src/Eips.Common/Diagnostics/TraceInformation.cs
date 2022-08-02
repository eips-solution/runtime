/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Globalization;
using System;
using System.Text;

namespace Niacomsoft.Eips.Diagnostics
{
    /// <summary> 提供了诊断内容相关的方法。 </summary>
    public class TraceInformation
    {
        /// <summary> 获取用于输出的消息前缀。 </summary>
        /// <returns> 统一诊断信息前缀。 </returns>
        protected virtual string GetUniversalMessagePrefix()
        {
            if (Target is null && string.IsNullOrWhiteSpace(MethodName))
                return string.Empty;
            var prefixBuilder = new StringBuilder();
            if (!(Target is null))
                prefixBuilder.Append($"类型 “{Target.FullName}”");
            if (!string.IsNullOrWhiteSpace(MethodName))
                prefixBuilder.Append($"{(Target is null ? string.Empty : " 的方法 ")}“{MethodName}”：");
            return prefixBuilder.ToString();
        }

        /// <summary> 用于初始化一个 <see cref="TraceInformation" /> 类型的对象实例。 </summary>
        /// <param name="message"> 诊断信息。 </param>
        public TraceInformation(string message) : this(null, null, message)
        {
        }

        /// <summary> 用于初始化一个 <see cref="TraceInformation" /> 类型的对象实例。 </summary>
        /// <param name="target">
        /// 需要诊断的目标类型。
        /// <para> <see cref="Type" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="message"> 诊断信息。 </param>
        public TraceInformation(Type target, string message) : this(target, null, message)
        {
        }

        /// <summary> 用于初始化一个 <see cref="TraceInformation" /> 类型的对象实例。 </summary>
        /// <param name="method"> 需要诊断的方法名称。 </param>
        /// <param name="message"> 诊断信息。 </param>
        public TraceInformation(string method, string message) : this(null, method, message)
        {
        }

        /// <summary> 用于初始化一个 <see cref="TraceInformation" /> 类型的对象实例。 </summary>
        /// <param name="target">
        /// 需要诊断的目标类型。
        /// <para> <see cref="Type" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="method"> 需要诊断的方法名称。 </param>
        /// <param name="message"> 诊断信息。 </param>
        public TraceInformation(Type target, string method, string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException(SR.Format("ArgumentException_empty_or_whitespace", nameof(message)), nameof(message));
            }

            Target = target;
            MethodName = method;
            Message = message;
        }

        /// <summary> 诊断信息。 </summary>
        /// <value> 获取一个字符串，用于表示诊断信息。 </value>
        public virtual string Message { get; }

        /// <summary> 需要诊断的方法名称。 </summary>
        /// <value> 获取一个字符串，用于表示需要诊断的方法名称。 </value>
        public virtual string MethodName { get; }

        /// <summary> 需要诊断的目标类型。 </summary>
        /// <value> 获取 <see cref="Type" /> 类型的对象实例，用于表示需要诊断的目标类型。 </value>
        /// <seealso cref="Type" />
        public virtual Type Target { get; }

        /// <summary> 获取完整的诊断信息。 </summary>
        /// <returns> 完整的诊断信息。 </returns>
        public override string ToString() => $"{GetUniversalMessagePrefix()}{Message}";

        /// <summary> 获取完整的诊断信息。 </summary>
        /// <param name="args"> 诊断信息格式化参数。 </param>
        /// <returns> 完整的诊断信息。 </returns>
        public virtual string ToString(params object[] args) => $"{GetUniversalMessagePrefix()}{string.Format(Message, args)}";
    }
}