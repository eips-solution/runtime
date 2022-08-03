/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Globalization;

namespace Niacomsoft.Eips
{
    public partial class StringUtilities
    {
        /// <summary> 将 <paramref name="value" /> 转换成货币格式字符串。 </summary>
        /// <param name="value"> <see cref="float" /> 类型的值。 </param>
        /// <param name="precision"> 货币精度。 </param>
        /// <param name="culture">
        /// 文化区域。
        /// <para> <see cref="CultureInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> 货币字符串。 </returns>
        /// <seealso cref="CultureInfo" />
        public static string ToCurrency(float value, int precision = 2, CultureInfo culture = null)
            => value.ToString($"C{precision}", culture);

        /// <summary> 将字符串转换成等效的 <see cref="float" /> 类型的值。 </summary>
        /// <param name="s"> 字符串。 </param>
        /// <returns> 等效的 <see cref="float" /> 类型的值。 </returns>
        /// <exception cref="System.FormatException">
        /// 当调用 <see cref="float.Parse(string)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        /// <exception cref="System.OverflowException">
        /// 当调用 <see cref="float.Parse(string)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        public static float ToSingle(string s) => float.Parse(s);

        /// <summary> 将 <paramref name="value" /> 转换成固定点数字字符串。 </summary>
        /// <param name="value"> <see cref="float" /> 类型的值。 </param>
        /// <param name="precision"> 小数精度。 </param>
        /// <returns> 固定小数精度的数字字符串。 </returns>
        public static string ToFixed(float value, int precision = 2) => value.ToString($"F{precision}");

        /// <summary> 尝试将字符串转换成等效的可为空的 <see cref="float" /> 类型的值。 </summary>
        /// <param name="s"> 字符串。 </param>
        /// <returns>
        /// 当调用 <see cref="float.TryParse(string, out float)" /> 方法返回 <c>
        /// false </c> 时，将返回 <c> null </c>。
        /// </returns>
        public static float? TryToSingle(string s) => float.TryParse(s, out float result) ? result : new float?();

        /// <summary> 将 <paramref name="value" /> 转换成含千分符的数字字符串。 </summary>
        /// <param name="value"> <see cref="float" /> 类型的值。 </param>
        /// <param name="precision"> 小数精度。 </param>
        /// <returns> 包含千分符的数字字符串。 </returns>
        public static string WithThousandSeparators(float value, int precision = 2) => value.ToString($"N{precision}");
    }
}