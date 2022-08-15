/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Options
{
    /// <summary>
    /// 提供了生成 NanoId 相关的配置选项。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IConfigurableOptions" />
    public sealed class NanoIdOptions : IConfigurableOptions
    {
        private const string c_defaultAlphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_-";
        private const int c_defaultSize = 0x15;

        /// <summary> 配置选项标识。 </summary>
        public const string Key = "eips:utilities:nanoid";

        /// <summary> 用于初始化一个 <see cref="NanoIdOptions" /> 类型的对象实例。 </summary>
        public NanoIdOptions() : this(c_defaultAlphabet, c_defaultSize)
        {
        }

        /// <summary> 用于初始化一个 <see cref="NanoIdOptions" /> 类型的对象实例。 </summary>
        /// <param name="alphabet"> 生成 NanoId 的字母表。 </param>
        public NanoIdOptions(string alphabet) : this(alphabet, c_defaultSize)
        {
        }

        /// <summary> 用于初始化一个 <see cref="NanoIdOptions" /> 类型的对象实例。 </summary>
        /// <param name="size"> 生成 NanoId 的长度。 </param>
        public NanoIdOptions(int? size) : this(c_defaultAlphabet, size)
        {
        }

        /// <summary> 用于初始化一个 <see cref="NanoIdOptions" /> 类型的对象实例。 </summary>
        /// <param name="alphabet"> 生成 NanoId 的字母表。 </param>
        /// <param name="size"> 生成 NanoId 的长度。 </param>
        public NanoIdOptions(string alphabet, int? size)
        {
            Alphabet = ParameterGuard.SafeGet(alphabet, c_defaultAlphabet, EmptyCompareOptions.IncludeWhiteSpace);
            Size = ParameterGuard.SafeGet(size, c_defaultSize);
        }

        /// <summary> 生成 NanoId 所需的字母表。 </summary>
        /// <value> 设置或获取一个字符串，用于表示生成 NanoId 所需的字母表。 </value>
        public string Alphabet { get; set; }

        /// <summary> 生成 NanoId 的长度。 </summary>
        /// <value> 设置或获取一个值，用于表示生成 NanoId 的长度。 </value>
        public int Size { get; set; }
    }
}