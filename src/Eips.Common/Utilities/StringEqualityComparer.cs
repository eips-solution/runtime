/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips
{
    /// <summary> 提供了字符串相等对比相关的方法。 </summary>
    public class StringEqualityComparer
    {
        /// <summary> 用于初始化一个 <see cref="StringEqualityComparer" /> 类型的对象实例。 </summary>
        private StringEqualityComparer()
        {
        }

        /// <summary>
        /// 用于校验字符串 <paramref name="s" /> 是否等于 <c> null </c>、
        /// <see cref="string.Empty" /> 或者空格符（需要参考 <paramref name="options" /> 的值）。
        /// </summary>
        /// <param name="s"> 需要对比的字符串。 </param>
        /// <param name="options">
        /// 空白字符串对比选项。
        /// <para> 默认为 <see cref="EmptyCompareOptions.Default" />。 </para>
        /// </param>
        /// <returns>
        /// 当字符串 <paramref name="s" /> 等于 <c> null </c>、
        /// <see cref="string.Empty" /> 或者空格符（需要参考 <paramref name="options" />
        /// 的值）时，则返回 <c> true </c>；否则返回 <c> false </c>。
        /// </returns>
        /// <seealso cref="EmptyCompareOptions" />
        public static bool Empty(string s, EmptyCompareOptions options = EmptyCompareOptions.Default)
        {
            if (options == EmptyCompareOptions.OnlyNull)
                return ReferenceTypeEqualityComparer.None(s);
            return options == EmptyCompareOptions.IncludeWhiteSpace
                ? string.IsNullOrWhiteSpace(s)
                : string.IsNullOrEmpty(s);
        }

        /// <summary>
        /// 忽略字符串的大小写，对比 <paramref name="s1" /> 与 <paramref name="s2" /> 是否相等。
        /// </summary>
        /// <param name="s1"> 字符串。 </param>
        /// <param name="s2"> 字符串。 </param>
        /// <returns>
        /// 当 <paramref name="s1" /> 与 <paramref name="s2" /> 忽略大小写相等时，则返回 <c>
        /// true </c>；否则返回 <c> false </c>。
        /// <para>
        /// 当 <paramref name="s1" /> 和 <paramref name="s2" /> 都为 <c> null </c>
        /// 时，则返回 <c> true </c>；否则返回 <c> false </c>。
        /// </para>
        /// </returns>
        /// <seealso cref="String.Equals(string, StringComparison)" />
        public static bool IgnoreCaseEquals(string s1, string s2)
        {
            if (ReferenceTypeEqualityComparer.None(s1) || ReferenceTypeEqualityComparer.None(s2))
                return ReferenceTypeEqualityComparer.None(s1) && ReferenceTypeEqualityComparer.None(s2);
            return s1.Equals(s2, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}