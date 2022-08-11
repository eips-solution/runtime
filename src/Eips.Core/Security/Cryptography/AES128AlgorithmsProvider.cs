/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Security.Cryptography;

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 提供了 128 位密钥 AES 算法相关的方法。 </summary>
    /// <seealso cref="SymmetricAlgorithms" />
    public class AES128AlgorithmsProvider : SymmetricAlgorithms
    {
        /// <summary> 初始化对称加密算法。 </summary>
        /// <param name="key">
        /// 实现了 <see cref="ISymmetricCryptographicKey" /> 类型接口的对象实例。
        /// </param>
        /// <param name="mode"> <see cref="CipherMode" /> 类型的值。 </param>
        /// <param name="padding"> <see cref="PaddingMode" /> 类型的值。 </param>
        /// <seealso cref="ISymmetricCryptographicKey" />
        /// <seealso cref="CipherMode" />
        /// <seealso cref="PaddingMode" />
        protected override void InitializeSymmetricAlgorithmsProvider(ISymmetricCryptographicKey key, CipherMode mode, PaddingMode padding)
        {
            base.InitializeSymmetricAlgorithmsProvider(key, mode, padding);
            Provider.IV = Provider.Key = (key as IAESCryptographicKey).GetKeyData128();
        }

        /// <summary> 用于初始化一个 <see cref="AES128AlgorithmsProvider" /> 类型的对象实例。 </summary>
        /// <param name="key">
        /// AES 算法加密密钥。
        /// <para> 实现了 <see cref="IAESCryptographicKey" /> 类型接口的对象实例。 </para>
        /// </param>
        /// <param name="cipherMode"> 默认的 <see cref="CipherMode" /> 类型的值。 </param>
        /// <param name="paddingMode"> 默认的 <see cref="PaddingMode" /> 类型的值。 </param>
        /// <exception cref="System.ArgumentNullException">
        /// 当 <paramref name="key" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        public AES128AlgorithmsProvider(IAESCryptographicKey key,
                                        CipherMode cipherMode = CipherMode.CBC,
                                        PaddingMode paddingMode = PaddingMode.PKCS7) : base(key, cipherMode, paddingMode)
            => Provider = Aes.Create();
    }
}