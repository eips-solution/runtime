/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips
{
    public partial class StringUtilities
    {
        /// <summary> 将字符串转换成等效的 <see cref="DateTime" /> 类型的值。 </summary>
        /// <param name="s"> 字符串。 </param>
        /// <returns> 等效的 <see cref="DateTime" /> 类型的值。 </returns>
        /// <exception cref="System.FormatException">
        /// 当调用 <see cref="DateTime.Parse(string)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        /// <exception cref="System.OverflowException">
        /// 当调用 <see cref="DateTime.Parse(string)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        public static DateTime ToDateTime(string s) => DateTime.Parse(s);

        /// <summary> 尝试将字符串转换成等效的可为空的 <see cref="DateTime" /> 类型的值。 </summary>
        /// <param name="s"> 字符串。 </param>
        /// <returns>
        /// 当调用 <see cref="DateTime.TryParse(string, out DateTime)" /> 方法返回 <c>
        /// false </c> 时，将返回 <c> null </c>。
        /// </returns>
        public static DateTime? TryToDateTime(string s) => DateTime.TryParse(s, out DateTime result) ? result : new DateTime?();
    }
}