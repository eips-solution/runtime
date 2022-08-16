/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 定义了 AES 算法密钥长度枚举类型。 </summary>
    public enum AESCryptographicKeySize
    {
        /// <summary> 128 位。 </summary>
        AES128 = 1,

        /// <summary> 192 位。 </summary>
        AES192 = 2,

        /// <summary> 256 位。 </summary>
        AES256 = 3,

        /// <summary> 默认的。等效于 <see cref="AES256" />。 </summary>
        Default = AES256
    }
}