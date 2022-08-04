/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;
using System.Globalization;

namespace Niacomsoft.Eips
{
    public partial class StringUtilities
    {
        /// <summary> 将 <paramref name="value" /> 转换成货币格式字符串。 </summary>
        /// <param name="value"> <see cref="short" /> 类型的值。 </param>
        /// <param name="precision"> 货币精度。 </param>
        /// <param name="culture">
        /// 文化区域。
        /// <para> <see cref="CultureInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> 货币字符串。 </returns>
        /// <seealso cref="CultureInfo" />
        public static string ToCurrency(short value, short precision = 2, CultureInfo culture = null)
            => value.ToString($"C{precision}", culture);

        /// <summary> 将 <paramref name="value" /> 转换成固定点数字字符串。 </summary>
        /// <param name="value"> <see cref="short" /> 类型的值。 </param>
        /// <param name="precision"> 小数精度。 </param>
        /// <returns> 固定小数精度的数字字符串。 </returns>
        public static string ToFixed(short value, short precision = 2) => value.ToString($"F{precision}");

        /// <summary> 将 <paramref name="value" /> 转换成十六进制字符串。 </summary>
        /// <param name="value"> <see cref="short" /> 类型的值。 </param>
        /// <returns> 十六进制字符串。 </returns>
        public static string ToHex(short value) => Convert.ToString(value, 0x10);

        /// <summary> 将字符串转换成等效的 <see cref="short" /> 类型的值。 </summary>
        /// <param name="s"> 字符串。 </param>
        /// <returns> 等效的 <see cref="short" /> 类型的值。 </returns>
        /// <exception cref="System.FormatException">
        /// 当调用 <see cref="short.Parse(string)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        /// <exception cref="System.OverflowException">
        /// 当调用 <see cref="short.Parse(string)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        public static short ToInt16(string s) => short.Parse(s);

        /// <summary> 尝试将字符串转换成等效的可为空的 <see cref="short" /> 类型的值。 </summary>
        /// <param name="s"> 字符串。 </param>
        /// <returns>
        /// 当调用 <see cref="short.TryParse(string, out short)" /> 方法返回 <c> false
        /// </c> 时，将返回 <c> null </c>。
        /// </returns>
        public static short? TryToInt16(string s) => short.TryParse(s, out short result) ? result : new short?();

        /// <summary> 将 <paramref name="value" /> 转换成含千分符的数字字符串。 </summary>
        /// <param name="value"> <see cref="short" /> 类型的值。 </param>
        /// <param name="precision"> 小数精度。 </param>
        /// <returns> 包含千分符的数字字符串。 </returns>
        public static string WithThousandSeparators(short value, short precision = 2) => value.ToString($"N{precision}");
    }
}