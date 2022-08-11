/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.IO;
using System.Security.Cryptography;

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 定义了对称加密算法的接口。 </summary>
    public interface ISymmetricAlgorithms
    {
        /// <summary> 默认的 <see cref="CipherMode" />。 </summary>
        /// <value> 获取一个值，用于表示默认的 <see cref="CipherMode" />。 </value>
        /// <seealso cref="CipherMode" />
        CipherMode DefaultCipherMode { get; }

        /// <summary> 默认的对称加密的密钥。 </summary>
        /// <value> 获取 <see cref="ISymmetricCryptographicKey" /> 类型的对象实例，用于表示默认的对称加密的密钥。 </value>
        /// <seealso cref="ISymmetricCryptographicKey" />
        ISymmetricCryptographicKey DefaultKey { get; }

        /// <summary> 默认的 <see cref="PaddingMode" />。 </summary>
        /// <value> 设置或获取一个值，用于表示默认的 <see cref="PaddingMode" />。 </value>
        /// <seealso cref="PaddingMode" />
        PaddingMode DefaultPaddingMode { get; }

        /// <summary> 解密。 </summary>
        /// <param name="encryptedDate"> 需要解密的字节数据。 </param>
        /// <param name="key">
        /// 加密密钥。
        /// <para> 当 <paramref name="key" /> 等于 <c> null </c> 时，将使用 <see cref="DefaultKey" />。 </para>
        /// </param>
        /// <param name="mode">
        /// 可为空的 <see cref="CipherMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="mode" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="DefaultCipherMode" />。
        /// </para>
        /// </param>
        /// <param name="padding">
        /// 可为空的 <see cref="PaddingMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="padding" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="DefaultPaddingMode" />。
        /// </para>
        /// </param>
        /// <returns> 加密后的字节数据。 </returns>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="CipherMode" />
        /// <seealso cref="PaddingMode" />
        byte[] Decrypt(byte[] encryptedDate,
                       ISymmetricCryptographicKey key = null,
                       CipherMode? mode = null,
                       PaddingMode? padding = null);

        /// <summary> 从 <paramref name="sourceStream" /> 读取数据并解密。 </summary>
        /// <param name="sourceStream">
        /// 加密的输入流。
        /// <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="key">
        /// 加密密钥。
        /// <para> 当 <paramref name="key" /> 等于 <c> null </c> 时，将使用 <see cref="DefaultKey" />。 </para>
        /// </param>
        /// <param name="mode">
        /// 可为空的 <see cref="CipherMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="mode" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="DefaultCipherMode" />。
        /// </para>
        /// </param>
        /// <param name="padding">
        /// 可为空的 <see cref="PaddingMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="padding" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="DefaultPaddingMode" />。
        /// </para>
        /// </param>
        /// <returns> 解密后的数据。 </returns>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="CipherMode" />
        /// <seealso cref="PaddingMode" />
        /// <seealso cref="Stream" />
        byte[] Decrypt(Stream sourceStream, ISymmetricCryptographicKey key = null, CipherMode? mode = null, PaddingMode? padding = null);

        /// <summary> 加密。 </summary>
        /// <param name="input"> 需要加密的字节数据。 </param>
        /// <param name="key">
        /// 加密密钥。
        /// <para> 当 <paramref name="key" /> 等于 <c> null </c> 时，将使用 <see cref="DefaultKey" />。 </para>
        /// </param>
        /// <param name="mode">
        /// 可为空的 <see cref="CipherMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="mode" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="DefaultCipherMode" />。
        /// </para>
        /// </param>
        /// <param name="padding">
        /// 可为空的 <see cref="PaddingMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="padding" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="DefaultPaddingMode" />。
        /// </para>
        /// </param>
        /// <returns> 加密后的字节数据。 </returns>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="CipherMode" />
        /// <seealso cref="PaddingMode" />
        byte[] Encrypt(byte[] input, ISymmetricCryptographicKey key = null, CipherMode? mode = null, PaddingMode? padding = null);

        /// <summary> 加密并将加密后的数据写入 <paramref name="destionationStream" />。 </summary>
        /// <param name="input"> 需要加密的字节数据。 </param>
        /// <param name="destionationStream">
        /// 目标流。
        /// <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="key">
        /// 加密密钥。
        /// <para> 当 <paramref name="key" /> 等于 <c> null </c> 时，将使用 <see cref="DefaultKey" />。 </para>
        /// </param>
        /// <param name="mode">
        /// 可为空的 <see cref="CipherMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="mode" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="DefaultCipherMode" />。
        /// </para>
        /// </param>
        /// <param name="padding">
        /// 可为空的 <see cref="PaddingMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="padding" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="DefaultPaddingMode" />。
        /// </para>
        /// </param>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="CipherMode" />
        /// <seealso cref="PaddingMode" />
        /// <seealso cref="Stream" />
        void Encrypt(byte[] input,
                     Stream destionationStream,
                     ISymmetricCryptographicKey key = null,
                     CipherMode? mode = null,
                     PaddingMode? padding = null);
    }
}