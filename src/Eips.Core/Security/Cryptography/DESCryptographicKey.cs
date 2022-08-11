/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 提供了 DES 算法密钥相关的方法。 </summary>
    /// <seealso cref="ISymmetricCryptographicKey" />
    /// <seealso cref="SymmetricCryptographicKey" />
    public class DESCryptographicKey : SymmetricCryptographicKey, ISymmetricCryptographicKey
    {
        private readonly string m_internalDesKey;

        /// <summary> 获取密钥字符串。 </summary>
        /// <returns> 密钥字符串。 </returns>
        protected override string InternalGetKeyString() => m_internalDesKey.Trim().PadRight(8, 'e').Substring(0, 8);

        /// <summary> 用于初始化一个 <see cref="DESCryptographicKey" /> 类型的对象实例。 </summary>
        public DESCryptographicKey()
        {
#if DEBUG
            m_internalDesKey = "K3LB3T-d";
#else
            m_internalDesKey = "sYmc_dkg";
#endif
        }
    }
}