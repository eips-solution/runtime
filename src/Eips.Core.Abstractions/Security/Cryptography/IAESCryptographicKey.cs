/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 定义了 AES 算法加密密钥的接口。 </summary>
    /// <seealso cref="ISymmetricCryptographicKey" />
    public interface IAESCryptographicKey : ISymmetricCryptographicKey
    {
        /// <summary> 获取 128 位的密钥数据。 </summary>
        /// <returns> 密钥数据。 </returns>
        byte[] GetKeyData128();

        /// <summary> 获取 192 位的密钥数据。 </summary>
        /// <returns> 密钥数据。 </returns>
        byte[] GetKeyData192();

        /// <summary> 获取 256 位的密钥数据。 </summary>
        /// <returns> 密钥数据。 </returns>
        byte[] GetKeyData256();
    }
}