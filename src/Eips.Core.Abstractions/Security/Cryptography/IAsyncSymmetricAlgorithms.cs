/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 定义了异步对称加密算法的接口。 </summary>
    /// <seealso cref="ISymmetricAlgorithms" />
    public interface IAsyncSymmetricAlgorithms : ISymmetricAlgorithms
    {
        /// <summary> (异步的方法) 从 <paramref name="sourceStream" /> 读取数据并解密。 </summary>
        /// <param name="sourceStream">
        /// 加密的输入流。
        /// <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="key">
        /// 加密密钥。
        /// <para> 当 <paramref name="key" /> 等于 <c> null </c> 时，将使用 <see cref="ISymmetricAlgorithms.DefaultKey" />。 </para>
        /// </param>
        /// <param name="mode">
        /// 可为空的 <see cref="CipherMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="mode" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="ISymmetricAlgorithms.DefaultCipherMode" />。
        /// </para>
        /// </param>
        /// <param name="padding">
        /// 可为空的 <see cref="PaddingMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="padding" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="ISymmetricAlgorithms.DefaultPaddingMode" />。
        /// </para>
        /// </param>
        /// <returns> 解密后的数据。 </returns>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="CipherMode" />
        /// <seealso cref="PaddingMode" />
        /// <seealso cref="Stream" />
        /// <seealso cref="Task{TResult}" />
        Task<byte[]> DecryptAsync(Stream sourceStream, ISymmetricCryptographicKey key = null, CipherMode? mode = null, PaddingMode? padding = null);

        /// <summary> (异步的方法) 解密。 </summary>
        /// <param name="encryptedData"> 需要解密的字节数据。 </param>
        /// <param name="key">
        /// 加密密钥。
        /// <para> 当 <paramref name="key" /> 等于 <c> null </c> 时，将使用 <see cref="ISymmetricAlgorithms.DefaultKey" />。 </para>
        /// </param>
        /// <param name="mode">
        /// 可为空的 <see cref="CipherMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="mode" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="ISymmetricAlgorithms.DefaultCipherMode" />。
        /// </para>
        /// </param>
        /// <param name="padding">
        /// 可为空的 <see cref="PaddingMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="padding" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="ISymmetricAlgorithms.DefaultPaddingMode" />。
        /// </para>
        /// </param>
        /// <returns> 加密后的字节数据。 </returns>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="CipherMode" />
        /// <seealso cref="PaddingMode" />
        /// <seealso cref="Task{TResult}" />
        Task<byte[]> DecryptAsync(byte[] encryptedData,
                       ISymmetricCryptographicKey key = null,
                       CipherMode? mode = null,
                       PaddingMode? padding = null);

        /// <summary> (异步的方法) 加密。 </summary>
        /// <param name="input"> 需要加密的字节数据。 </param>
        /// <param name="key">
        /// 加密密钥。
        /// <para> 当 <paramref name="key" /> 等于 <c> null </c> 时，将使用 <see cref="ISymmetricAlgorithms.DefaultKey" />。 </para>
        /// </param>
        /// <param name="mode">
        /// 可为空的 <see cref="CipherMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="mode" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="ISymmetricAlgorithms.DefaultCipherMode" />。
        /// </para>
        /// </param>
        /// <param name="padding">
        /// 可为空的 <see cref="PaddingMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="padding" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="ISymmetricAlgorithms.DefaultPaddingMode" />。
        /// </para>
        /// </param>
        /// <returns> 加密后的字节数据。 </returns>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="CipherMode" />
        /// <seealso cref="PaddingMode" />
        /// <seealso cref="Task{TResult}" />
        Task<byte[]> EncryptAsync(byte[] input, ISymmetricCryptographicKey key = null, CipherMode? mode = null, PaddingMode? padding = null);

        /// <summary> (异步的方法) 加密并将加密后的数据写入 <paramref name="destionationStream" />。 </summary>
        /// <param name="input"> 需要加密的字节数据。 </param>
        /// <param name="destionationStream">
        /// 目标流。
        /// <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="key">
        /// 加密密钥。
        /// <para> 当 <paramref name="key" /> 等于 <c> null </c> 时，将使用 <see cref="ISymmetricAlgorithms.DefaultKey" />。 </para>
        /// </param>
        /// <param name="mode">
        /// 可为空的 <see cref="CipherMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="mode" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="ISymmetricAlgorithms.DefaultCipherMode" />。
        /// </para>
        /// </param>
        /// <param name="padding">
        /// 可为空的 <see cref="PaddingMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="padding" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="ISymmetricAlgorithms.DefaultPaddingMode" />。
        /// </para>
        /// </param>
        /// <returns> <see cref="Task" /> 类型的对象实例。 </returns>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="CipherMode" />
        /// <seealso cref="PaddingMode" />
        /// <seealso cref="Stream" />
        /// <seealso cref="Task" />
        Task EncryptAsync(byte[] input,
                     Stream destionationStream,
                     ISymmetricCryptographicKey key = null,
                     CipherMode? mode = null,
                     PaddingMode? padding = null);
    }
}