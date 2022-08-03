/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Diagnostics;
using System.Diagnostics;
using System.Text;

namespace Niacomsoft.Eips
{
    public partial class StringUtilities
    {
        /// <summary> 使用指定的编码获取字符串 <paramref name="s" /> 的字节数组。 </summary>
        /// <param name="s"> 字符串。 </param>
        /// <param name="encoding">
        /// 编码程序。
        /// <para> 派生自 <see cref="Encoding" /> 类型的对象实例。 </para>
        /// <para> 当 <paramref name="encoding" /> 等于 <c> null </c> 时，将使用 <see cref="Defaults.DefaultEncoding" />。 </para>
        /// </param>
        /// <returns>
        /// 字节数组。
        /// <para>
        /// 当 <paramref name="s" /> 等于 <c> null </c> 时，将返回 <c> null </c>。
        /// </para>
        /// </returns>
        /// <seealso cref="Encoding" />
        /// <seealso cref="Defaults.DefaultEncoding" />
        public static byte[] GetBytes(string s, Encoding encoding = null)
        {
            if (StringEqualityComparer.Empty(s, EmptyCompareOptions.OnlyNull))
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget<StringUtilities>()
                                                             .WithMethod(nameof(GetBytes))
                                                             .WithMessage($"字符串 “{nameof(s)}” 等于 null，将返回 null。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);

                return null;
            }

            return ParameterGuard.SafeGet(encoding, () => Defaults.DefaultEncoding).GetBytes(s);
        }

        /// <summary> 使用指定的编码获取字符串。 </summary>
        /// <param name="bytes"> 字节数组。 </param>
        /// <param name="encoding">
        /// 编码程序。
        /// <para> 当 <paramref name="encoding" /> 等于 <c> null </c> 时，将使用 <see cref="Defaults.DefaultEncoding" />。 </para>
        /// </param>
        /// <returns>
        /// 字符串。
        /// <para>
        /// 当 <paramref name="bytes" /> 等于 <c> null </c> 或者长度等于 0 时，将返回 <c> null </c>。
        /// </para>
        /// </returns>
        /// <seealso cref="Encoding" />
        /// <seealso cref="Defaults.DefaultEncoding" />
        public static string GetString(byte[] bytes, Encoding encoding = null)
        {
            if (ReferenceTypeEqualityComparer.None(bytes) || ValueTypeComparer.Compare(bytes.LongLength))
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget<StringUtilities>()
                                                             .WithMethod(nameof(GetString))
                                                             .WithMessage($"字节数组 “{nameof(bytes)}” 等于 null、或者 “{nameof(bytes)}.LongLength” 等于 0，将返回 null。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);

                return null;
            }

            return ParameterGuard.SafeGet(encoding, () => Defaults.DefaultEncoding).GetString(bytes);
        }
    }
}