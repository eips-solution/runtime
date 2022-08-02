/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Diagnostics;
using System;
using System.Diagnostics;

namespace Niacomsoft.Eips
{
    /// <summary> 提供了安全的参数值相关的方法。 </summary>
    public class ParameterGuard
    {
        /// <summary> 用于初始化一个 <see cref="ParameterGuard" /> 类型的对象实例。 </summary>
        private ParameterGuard()
        {
        }

        /// <summary>
        /// 当 <paramref name="instance" /> 等于 <c> null </c> 时，则使用
        /// <paramref name="safeGuard" /> 的返回值；否则使用 <paramref name="instance" />。
        /// </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="instance"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <param name="safeGuard"> 构建安全参数值的方法。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        public static T SafeGet<T>(T instance, Func<T> safeGuard) where T : class
            => TrueGet(instance, value => ReferenceTypeEqualityComparer.None(value), safeGuard);

        /// <summary>
        /// 当 <c> value.HasValue </c> 等于 <c> true </c> 时，则返回 <c> value.Value
        /// </c>；否则返回 <paramref name="safeValue" />。
        /// </summary>
        /// <typeparam name="T"> 值类型。 </typeparam>
        /// <param name="value"> 可能为空的 <typeparamref name="T" /> 类型的值。 </param>
        /// <param name="safeValue"> <typeparamref name="T" /> 类型的值。 </param>
        /// <returns> <typeparamref name="T" /> 类型的值。 </returns>
        /// <seealso cref="Nullable{T}" />
        public static T SafeGet<T>(T? value, T safeValue) where T : struct
            => value.HasValue ? value.Value : safeValue;

        /// <summary>
        /// 当
        /// <see cref="StringEqualityComparer.Empty(string, EmptyCompareOptions)" />
        /// 返回 <c> true </c> 时，则返回 <paramref name="safeString" />；否则返回 <paramref name="s" />。
        /// </summary>
        /// <param name="s"> 原始字符串。 </param>
        /// <param name="safeString"> 安全字符串。 </param>
        /// <param name="options">
        /// 空白字符串选项。
        /// <para> <see cref="EmptyCompareOptions" /> 类型的值。 </para>
        /// </param>
        /// <returns> 字符串。 </returns>
        /// <seealso cref="EmptyCompareOptions" />
        public static string SafeGet(string s, string safeString, EmptyCompareOptions options = EmptyCompareOptions.OnlyNull)
            => StringEqualityComparer.Empty(s, options) ? safeString : s;

        /// <summary>
        /// 当条件表达式 <paramref name="where" /> 返回 <c> true </c> 时，则使用
        /// <paramref name="safeGuard" /> 作为参数值；否则使用 <paramref name="source" /> 作为最终参数值。
        /// </summary>
        /// <typeparam name="T"> 参数值类型。 </typeparam>
        /// <param name="source"> 原始参数值。 </param>
        /// <param name="where"> 条件表达式。 </param>
        /// <param name="safeGuard"> 构建安全参数值的方法。 </param>
        /// <returns> <typeparamref name="T" /> 类型的参数值。 </returns>
        /// <seealso cref="Func{T, TResult}" />
        /// <seealso cref="Func{TResult}" />
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="safeGuard" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        public static T TrueGet<T>(T source, Func<T, bool> where, Func<T> safeGuard)
        {
            var condition = ReferenceTypeEqualityComparer.None(where);
            Trace.WriteIf(condition,
                          new TraceInformationBuilder().WithTarget<ParameterGuard>()
                                                       .WithMethod(nameof(TrueGet))
                                                       .WithMessage($"条件表达式 “{nameof(where)}” 等于 null，将默认认为条件表达式为 “True”。")
                                                       .Build(),
                          Defaults.DefaultDiagnosticCategory);
            if (!condition)
                condition = where(source);
            if (condition && ReferenceTypeEqualityComparer.None(safeGuard))
                throw new ArgumentNullException(nameof(safeGuard));
            return condition ? safeGuard() : source;
        }
    }
}