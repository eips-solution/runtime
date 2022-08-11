/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 定义了对称加密算法密钥的接口。 </summary>
    public interface ISymmetricCryptographicKey
    {
        /// <summary> 获取密钥字节数据。 </summary>
        /// <returns> 字节数组。 </returns>
        /// <seealso cref="System.Text.UTF8Encoding" />
        byte[] GetKeyData();
    }
}