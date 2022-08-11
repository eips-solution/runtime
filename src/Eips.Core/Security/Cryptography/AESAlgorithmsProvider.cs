/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Security.Cryptography;

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary>
    /// 提供了默认的 AES 算法相关的方法。
    /// <para> 等同于 <see cref="AES256AlgorithmsProvider" />。 </para>
    /// </summary>
    /// <seealso cref="SymmetricAlgorithms" />
    /// <seealso cref="AES256AlgorithmsProvider" />
    public class AESAlgorithmsProvider : AES256AlgorithmsProvider
    {
        /// <summary> 用于初始化一个 <see cref="AESAlgorithmsProvider" /> 类型的对象实例。 </summary>
        /// <param name="key">
        /// AES 算法加密密钥。
        /// <para> 实现了 <see cref="IAESCryptographicKey" /> 类型接口的对象实例。 </para>
        /// </param>
        /// <param name="cipherMode"> 默认的 <see cref="CipherMode" /> 类型的值。 </param>
        /// <param name="paddingMode"> 默认的 <see cref="PaddingMode" /> 类型的值。 </param>
        /// <exception cref="System.ArgumentNullException">
        /// 当 <paramref name="key" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        public AESAlgorithmsProvider(IAESCryptographicKey key,
                                        CipherMode cipherMode = CipherMode.CBC,
                                        PaddingMode paddingMode = PaddingMode.PKCS7) : base(key, cipherMode, paddingMode)
        {
        }
    }
}