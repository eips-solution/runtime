/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Diagnostics;
using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 提供了对称加密相关的基本方法。 </summary>
    /// <seealso cref="ISymmetricAlgorithms" />
    /// <seealso cref="IAsyncSymmetricAlgorithms" />
    /// <seealso cref="CryptographicAlgorithms" />
    public abstract partial class SymmetricAlgorithms : CryptographicAlgorithms, ISymmetricAlgorithms
    {
        private const int c_bufferSize = 0x400;

        /// <summary> 初始化对称加密算法。 </summary>
        /// <param name="key">
        /// 实现了 <see cref="ISymmetricCryptographicKey" /> 类型接口的对象实例。
        /// </param>
        /// <param name="mode"> <see cref="CipherMode" /> 类型的值。 </param>
        /// <param name="padding"> <see cref="PaddingMode" /> 类型的值。 </param>
        /// <seealso cref="ISymmetricCryptographicKey" />
        /// <seealso cref="CipherMode" />
        /// <seealso cref="PaddingMode" />
        protected virtual void InitializeSymmetricAlgorithmsProvider(ISymmetricCryptographicKey key, CipherMode mode, PaddingMode padding)
        {
            Provider.IV = Provider.Key = key.GetKeyData();
            Provider.Mode = mode;
            Provider.Padding = padding;
        }

        /// <summary> 为参数赋值。 </summary>
        /// <param name="key">
        /// 加密密钥。
        /// <para> 当 <paramref name="key" /> 等于 <c> null </c> 时，将使用 <see cref="P:Niacomsoft.Eips.Security.Cryptography.ISymmetricAlgorithms.DefaultKey" />。 </para>
        /// </param>
        /// <param name="mode">
        /// 可为空的 <see cref="CipherMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="mode" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="P:Niacomsoft.Eips.Security.Cryptography.ISymmetricAlgorithms.DefaultCipherMode" />。
        /// </para>
        /// </param>
        /// <param name="padding">
        /// 可为空的 <see cref="PaddingMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="padding" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="P:Niacomsoft.Eips.Security.Cryptography.ISymmetricAlgorithms.DefaultPaddingMode" />。
        /// </para>
        /// </param>
        private void ParameterAssign(ref ISymmetricCryptographicKey key, ref CipherMode? mode, ref PaddingMode? padding)
        {
            if (ReferenceTypeEqualityComparer.None(key))
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget(GetType())
                                                             .WithMethod(nameof(Encrypt))
                                                             .WithMethod($"对称加密密钥 “{nameof(key)}” 等于 null，将使用 “{nameof(DefaultKey)}” 替代。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);

                key = DefaultKey;
            }
            if (!mode.HasValue)
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget(GetType())
                                                             .WithMethod(nameof(Encrypt))
                                                             .WithMethod($"{nameof(CipherMode)} 类型参数 “{nameof(mode)}” 等于 null，将使用 “{nameof(DefaultCipherMode)}” 替代。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);

                mode = DefaultCipherMode;
            }
            if (!padding.HasValue)
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget(GetType())
                                                             .WithMethod(nameof(Encrypt))
                                                             .WithMethod($"{nameof(PaddingMode)} 类型参数 “{nameof(padding)}” 等于 null，将使用 “{nameof(DefaultPaddingMode)}” 替代。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);

                padding = DefaultPaddingMode;
            }
        }

        /// <summary> 用于初始化一个 <see cref="SymmetricAlgorithms" /> 类型的对象实例。 </summary>
        /// <param name="key"> 默认的对称加密密钥。 </param>
        /// <param name="cipherMode"> 默认的 <see cref="CipherMode" /> 类型的值。 </param>
        /// <param name="paddingMode"> 默认的 <see cref="PaddingMode" /> 类型的值。 </param>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="key" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        protected SymmetricAlgorithms(ISymmetricCryptographicKey key,
                                      CipherMode cipherMode = CipherMode.CBC,
                                      PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            DefaultKey = key;
            DefaultCipherMode = cipherMode;
            DefaultPaddingMode = paddingMode;
        }

        /// <summary> 对称加密算法。 </summary>
        /// <value>
        /// 获取 <see cref="SymmetricAlgorithm" /> 类型的对象实例，用于表示对称加密算法。
        /// <para> 派生自 <see cref="SymmetricAlgorithm" /> 类型的对象实例。 </para>
        /// </value>
        /// <seealso cref="SymmetricAlgorithm" />
        protected abstract SymmetricAlgorithm Provider { get; }

        /// <summary> 默认的 <see cref="CipherMode" />。 </summary>
        /// <value> 获取一个值，用于表示默认的 <see cref="CipherMode" />。 </value>
        /// <seealso cref="CipherMode" />
        public virtual CipherMode DefaultCipherMode
        {
            get;
        }

        /// <summary> 默认的对称加密的密钥。 </summary>
        /// <value> 获取 <see cref="ISymmetricCryptographicKey" /> 类型的对象实例，用于表示默认的对称加密的密钥。 </value>
        /// <seealso cref="ISymmetricCryptographicKey" />
        public virtual ISymmetricCryptographicKey DefaultKey
        {
            get;
        }

        /// <summary> 默认的 <see cref="PaddingMode" />。 </summary>
        /// <value> 设置或获取一个值，用于表示默认的 <see cref="PaddingMode" />。 </value>
        /// <seealso cref="PaddingMode" />
        public virtual PaddingMode DefaultPaddingMode
        {
            get;
        }

        /// <summary> 解密。 </summary>
        /// <param name="encryptedData"> 需要解密的字节数据。 </param>
        /// <param name="key">
        /// 加密密钥。
        /// <para> 当 <paramref name="key" /> 等于 <c> null </c> 时，将使用 <see cref="P:Niacomsoft.Eips.Security.Cryptography.ISymmetricAlgorithms.DefaultKey" />。 </para>
        /// </param>
        /// <param name="mode">
        /// 可为空的 <see cref="CipherMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="mode" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="P:Niacomsoft.Eips.Security.Cryptography.ISymmetricAlgorithms.DefaultCipherMode" />。
        /// </para>
        /// </param>
        /// <param name="padding">
        /// 可为空的 <see cref="PaddingMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="padding" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="P:Niacomsoft.Eips.Security.Cryptography.ISymmetricAlgorithms.DefaultPaddingMode" />。
        /// </para>
        /// </param>
        /// <returns> 加密后的字节数据。 </returns>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="CipherMode" />
        /// <seealso cref="PaddingMode" />
        /// <exception cref="CryptographicException">
        /// 当 <paramref name="encryptedData" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        public virtual byte[] Decrypt(byte[] encryptedData, ISymmetricCryptographicKey key = null, CipherMode? mode = null, PaddingMode? padding = null)
        {
            NullBinaryData(encryptedData);
            using (var bufferStream = new MemoryStream(encryptedData))
            {
                bufferStream.Seek(0, SeekOrigin.Begin);
                return Decrypt(bufferStream, key, mode, padding);
            }
        }

        /// <summary> 从 <paramref name="sourceStream" /> 读取数据并解密。 </summary>
        /// <param name="sourceStream">
        /// 加密的输入流。
        /// <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="key">
        /// 加密密钥。
        /// <para> 当 <paramref name="key" /> 等于 <c> null </c> 时，将使用 <see cref="P:Niacomsoft.Eips.Security.Cryptography.ISymmetricAlgorithms.DefaultKey" />。 </para>
        /// </param>
        /// <param name="mode">
        /// 可为空的 <see cref="CipherMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="mode" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="P:Niacomsoft.Eips.Security.Cryptography.ISymmetricAlgorithms.DefaultCipherMode" />。
        /// </para>
        /// </param>
        /// <param name="padding">
        /// 可为空的 <see cref="PaddingMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="padding" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="P:Niacomsoft.Eips.Security.Cryptography.ISymmetricAlgorithms.DefaultPaddingMode" />。
        /// </para>
        /// </param>
        /// <returns> 解密后的数据。 </returns>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="CipherMode" />
        /// <seealso cref="PaddingMode" />
        /// <seealso cref="Stream" />
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="sourceStream" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        public virtual byte[] Decrypt(Stream sourceStream, ISymmetricCryptographicKey key = null, CipherMode? mode = null, PaddingMode? padding = null)
        {
            if (ReferenceTypeEqualityComparer.None(sourceStream))
                throw new ArgumentNullException(nameof(sourceStream));
            ParameterAssign(ref key, ref mode, ref padding);
            InitializeSymmetricAlgorithmsProvider(key, mode.Value, padding.Value);
            using (var cryptoStream = new CryptoStream(sourceStream, Provider.CreateDecryptor(), CryptoStreamMode.Read))
            {
                using (var outputStream = new MemoryStream())
                {
                    var buffer = new byte[c_bufferSize];
                    var readSize = cryptoStream.Read(buffer, 0, c_bufferSize);
                    while (ValueTypeComparer.Compare(readSize, symbol: NumberComparisonSymbols.GreaterThanOrEqual))
                    {
                        outputStream.Write(buffer, 0, readSize);
                        cryptoStream.Read(buffer, 0, c_bufferSize);
                    }
                    return outputStream.ToArray();
                }
            }
        }

        /// <summary> 加密。 </summary>
        /// <param name="input"> 需要加密的字节数据。 </param>
        /// <param name="key">
        /// 加密密钥。
        /// <para> 当 <paramref name="key" /> 等于 <c> null </c> 时，将使用 <see cref="P:Niacomsoft.Eips.Security.Cryptography.ISymmetricAlgorithms.DefaultKey" />。 </para>
        /// </param>
        /// <param name="mode">
        /// 可为空的 <see cref="CipherMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="mode" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="P:Niacomsoft.Eips.Security.Cryptography.ISymmetricAlgorithms.DefaultCipherMode" />。
        /// </para>
        /// </param>
        /// <param name="padding">
        /// 可为空的 <see cref="PaddingMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="padding" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="P:Niacomsoft.Eips.Security.Cryptography.ISymmetricAlgorithms.DefaultPaddingMode" />。
        /// </para>
        /// </param>
        /// <returns> 加密后的字节数据。 </returns>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="CipherMode" />
        /// <seealso cref="PaddingMode" />
        /// <exception cref="CryptographicException">
        /// 当 <paramref name="input" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        public virtual byte[] Encrypt(byte[] input, ISymmetricCryptographicKey key = null, CipherMode? mode = null, PaddingMode? padding = null)
        {
            NullBinaryData(input);
            ParameterAssign(ref key, ref mode, ref padding);
            using (var outputStream = new MemoryStream(input))
            {
                outputStream.Seek(0, SeekOrigin.Begin);
                InitializeSymmetricAlgorithmsProvider(key, mode.Value, padding.Value);
                using (var cryptoStream = new CryptoStream(outputStream, Provider.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(input, 0, input.Length);
                    cryptoStream.FlushFinalBlock();
                    return outputStream.ToArray();
                }
            }
        }

        /// <summary> 加密并将加密后的数据写入 <paramref name="destionationStream" />。 </summary>
        /// <param name="input"> 需要加密的字节数据。 </param>
        /// <param name="destionationStream">
        /// 目标流。
        /// <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="key">
        /// 加密密钥。
        /// <para> 当 <paramref name="key" /> 等于 <c> null </c> 时，将使用 <see cref="P:Niacomsoft.Eips.Security.Cryptography.ISymmetricAlgorithms.DefaultKey" />。 </para>
        /// </param>
        /// <param name="mode">
        /// 可为空的 <see cref="CipherMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="mode" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="P:Niacomsoft.Eips.Security.Cryptography.ISymmetricAlgorithms.DefaultCipherMode" />。
        /// </para>
        /// </param>
        /// <param name="padding">
        /// 可为空的 <see cref="PaddingMode" /> 类型的值。
        /// <para>
        /// 当 <paramref name="padding" />.HasValue 等于 <c> false </c> 时，将使用 <see cref="P:Niacomsoft.Eips.Security.Cryptography.ISymmetricAlgorithms.DefaultPaddingMode" />。
        /// </para>
        /// </param>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="CipherMode" />
        /// <seealso cref="PaddingMode" />
        /// <seealso cref="Stream" />
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="destionationStream" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        /// <exception cref="CryptographicException">
        /// 当调用
        /// <see cref="Encrypt(byte[], ISymmetricCryptographicKey, CipherMode?, PaddingMode?)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        public virtual void Encrypt(byte[] input, Stream destionationStream, ISymmetricCryptographicKey key = null, CipherMode? mode = null, PaddingMode? padding = null)
        {
            if (ReferenceTypeEqualityComparer.None(destionationStream))
                throw new ArgumentNullException(nameof(destionationStream));
            byte[] encryptedData = Encrypt(input, key, mode, padding);
            destionationStream.Write(encryptedData, 0, encryptedData.Length);
        }
    }
}