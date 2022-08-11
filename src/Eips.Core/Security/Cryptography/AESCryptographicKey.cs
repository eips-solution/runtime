/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 提供了 AES 算法加密密钥相关的方法。 </summary>
    /// <seealso cref="IAESCryptographicKey" />
    /// <seealso cref="ISymmetricCryptographicKey" />
    public class AESCryptographicKey : IAESCryptographicKey, ISymmetricCryptographicKey
    {
        private readonly string m_128;
        private readonly string m_192;
        private readonly string m_256;

        /// <summary> 用于初始化一个 <see cref="AESCryptographicKey" /> 类型的对象实例。 </summary>
        public AESCryptographicKey()
        {
#if DEBUG
            m_128 = "lEKsi-50";
            m_192 = "S-pKMsVVOoHr";
            m_256 = "K-SdYJSGlzGZBYvu";
#else
            m_128 = "9cr4-Goz";
            m_192 = "OqpPwszNZ-pR";
            m_256 = "FD-JCz8J5qK_e9pI";
#endif
        }

        /// <summary>
        /// 获取密钥字节数据。
        /// <para> 等同于 <see cref="GetKeyData256" />。 </para>
        /// </summary>
        /// <returns> 字节数组。 </returns>
        /// <seealso cref="System.Text.UTF8Encoding" />
        public virtual byte[] GetKeyData() => GetKeyData256();

        /// <summary> 获取 128 位的密钥数据。 </summary>
        /// <returns> 密钥数据。 </returns>
        public virtual byte[] GetKeyData128()
        {
            return StringUtilities.GetBytes(m_128.Trim().PadRight(8, 'e').Substring(0, 8));
        }

        /// <summary> 获取 192 位的密钥数据。 </summary>
        /// <returns> 密钥数据。 </returns>
        public virtual byte[] GetKeyData192() => StringUtilities.GetBytes(m_192.Trim().PadRight(12, 'e').Substring(0, 12));

        /// <summary> 获取 256 位的密钥数据。 </summary>
        /// <returns> 密钥数据。 </returns>
        public virtual byte[] GetKeyData256() => StringUtilities.GetBytes(m_256.Trim().PadRight(16, 'e').Substring(0, 16));
    }
}