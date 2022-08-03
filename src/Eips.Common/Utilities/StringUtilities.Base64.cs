/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Diagnostics;
using System;
using System.Diagnostics;

namespace Niacomsoft.Eips
{
    public partial class StringUtilities
    {
        /// <summary> 从 BASE-64 格式字符串获取字节数组。 </summary>
        /// <param name="base64Str"> BASE-64 格式字符串。 </param>
        /// <returns>
        /// 字节数组。
        /// <para>
        /// 当字符串 <paramref name="base64Str" /> 等于 <c> null </c> 或者
        /// <see cref="string.Empty" /> 时，将返回 <c> null </c>。
        /// </para>
        /// </returns>
        /// <exception cref="FormatException">
        /// 当调用 <see cref="Convert.FromBase64String(string)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        /// <seealso cref="Convert" />
        public static byte[] FromBase64String(string base64Str)
        {
            if (StringEqualityComparer.Empty(base64Str, EmptyCompareOptions.OnlyEmpty))
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget<StringUtilities>()
                                                             .WithMethod(nameof(FromBase64String))
                                                             .WithMessage($"BASE-64 字符串 “{nameof(base64Str)}” 等于 null 或者 string.Empty，将返回 null。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);

                return null;
            }

            return Convert.FromBase64String(base64Str);
        }

        /// <summary> 将字节数组 <paramref name="bytes" /> 转换成 BASE-64 格式字符串。 </summary>
        /// <param name="bytes"> 字节数组。 </param>
        /// <param name="options">
        /// BASE-64 格式化选项。
        /// <para> <see cref="Base64FormattingOptions" /> 类型的值。 </para>
        /// </param>
        /// <returns>
        /// BASE-64 格式字符串。
        /// <para>
        /// 当 <paramref name="bytes" /> 等于 <c> null </c> 或者长度等于 0 时，将返回 <c> null </c>。
        /// </para>
        /// </returns>
        /// <seealso cref="Base64FormattingOptions" />
        /// <seealso cref="Convert" />
        public static string ToBase64String(byte[] bytes, Base64FormattingOptions options = Base64FormattingOptions.None)
        {
            if (ReferenceTypeEqualityComparer.None(bytes) || ValueTypeComparer.Compare(bytes.LongLength))
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget<StringUtilities>()
                                             .WithMethod(nameof(ToBase64String))
                                             .WithMessage($"字节数组 “{nameof(bytes)}” 等于 null 或者 “{nameof(bytes)}.LongLength” 等于 0，将返回 null。")
                                             .Build(),
                Defaults.DefaultDiagnosticCategory);

                return null;
            }

            return Convert.ToBase64String(bytes, options);
        }
    }
}