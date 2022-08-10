/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.ComponentModel;

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 定义了 EIPS 提供的哈希算法枚举类型。 </summary>
    public enum SupportedHashAlgorithms
    {
        /// <summary> MD5 哈希算法。 </summary>
        [Description(nameof(MD5))]
        MD5 = 1,

        /// <summary> SHA-1 哈希算法。 </summary>
        [Description(nameof(SHA1))]
        SHA1 = 2,

        /// <summary> SHA-256 哈希算法。 </summary>
        [Description(nameof(SHA256))]
        SHA256 = 3,

        /// <summary> SHA-384 哈希算法。 </summary>
        [Description(nameof(SHA384))]
        SHA384 = 4,

        /// <summary> SHA-512 哈希算法。 </summary>
        [Description(nameof(SHA512))]
        SHA512 = 5,

        /// <summary> 默认的哈希算法。等效于 <see cref="MD5" />。 </summary>
        [Description(nameof(MD5))]
        Default = MD5
    }
}