/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Security.Cryptography;

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 提供了 DES 对称加密算法相关的方法。 </summary>
    /// <seealso cref="SymmetricAlgorithms" />
    public class DESAlgorithmsProvider : SymmetricAlgorithms
    {
        /// <summary> 用于初始化一个 <see cref="DESAlgorithmsProvider" /> 类型的对象实例。 </summary>
        /// <param name="key">
        /// DES 算法加密密钥。
        /// <para> 派生自 <see cref="DESCryptographicKey" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="cipherMode"> 默认的 <see cref="CipherMode" /> 类型的值。 </param>
        /// <param name="paddingMode"> 默认的 <see cref="PaddingMode" /> 类型的值。 </param>
        /// <exception cref="System.ArgumentNullException">
        /// 当 <paramref name="key" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        public DESAlgorithmsProvider(DESCryptographicKey key,
                                     CipherMode cipherMode = CipherMode.CBC,
                                     PaddingMode paddingMode = PaddingMode.PKCS7) : base(key, cipherMode, paddingMode)
            => Provider = DES.Create();
    }
}