/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;
using System.IO;
using System.Security.Cryptography;

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary>
    /// 提供了 SHA-512 哈希算法相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IHashAlgorithms" />
    /// <seealso cref="IAsyncHashAlgorithms" />
    /// <seealso cref="HashAlgorithms" />
    public sealed class SHA512AlgorithmsProvider : HashAlgorithms
    {
        /// <summary> 哈希算法。 </summary>
        /// <value>
        /// 获取
        /// <see cref="P:Niacomsoft.Eips.Security.Cryptography.HashAlgorithms.HashAlgorithm" /> 类型的对象实例，用于表示哈希算法。
        /// <para>
        /// 派生自
        /// <see cref="P:Niacomsoft.Eips.Security.Cryptography.HashAlgorithms.HashAlgorithm" /> 类型的对象实例。
        /// </para>
        /// </value>
        /// <seealso cref="P:Niacomsoft.Eips.Security.Cryptography.HashAlgorithms.HashAlgorithm" />
        protected override HashAlgorithm Provider { get; }

        /// <summary> 用于初始化一个 <see cref="SHA512AlgorithmsProvider" /> 类型的对象实例。 </summary>
        public SHA512AlgorithmsProvider()
        {
            Provider = SHA512.Create();
        }

        /// <summary> 计算哈希。 </summary>
        /// <param name="input"> 需要计算的字节数组。 </param>
        /// <returns> 哈希计算后的字节数组。 </returns>
        /// <exception cref="CryptographicException">
        /// 当 <paramref name="input" /> 等于 <c> null </c> 时，可能引发此类型的异常。
        /// </exception>
        public override byte[] ComputeHash(byte[] input)
        {
            NullBinaryData(input);
            return Provider.ComputeHash(input);
        }

        /// <summary> 计算哈希数据，并写入流 <paramref name="stream" />。 </summary>
        /// <param name="input"> 字节数组。 </param>
        /// <param name="stream">
        /// 目标流。
        /// <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
        /// </param>
        /// <seealso cref="Stream" />
        /// <exception cref="CryptographicException">
        /// 当 <paramref name="input" /> 等于 <c> null </c> 时，可能引发此类型的异常。
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="stream" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        public override void ComputeHash(byte[] input, Stream stream)
        {
            if (ReferenceTypeEqualityComparer.None(stream))
            {
                throw new ArgumentNullException(nameof(stream));
            }

            WriteToStream(ComputeHash(input), stream);
        }
    }
}