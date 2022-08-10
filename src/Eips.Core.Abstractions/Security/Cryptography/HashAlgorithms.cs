/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.IO;
using System.Security.Cryptography;

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 提供了哈希计算相关的基本方法。 </summary>
    /// <seealso cref="IHashAlgorithms" />
    /// <seealso cref="CryptographicAlgorithms" />
    public abstract class HashAlgorithms : CryptographicAlgorithms, IHashAlgorithms
    {
        /// <summary> 用于初始化一个 <see cref="HashAlgorithms" /> 类型的对象实例。 </summary>
        protected HashAlgorithms() : base()
        {
        }

        /// <summary> 哈希算法。 </summary>
        /// <value>
        /// 获取 <see cref="HashAlgorithm" /> 类型的对象实例，用于表示哈希算法。
        /// <para> 派生自 <see cref="HashAlgorithm" /> 类型的对象实例。 </para>
        /// </value>
        /// <seealso cref="HashAlgorithm" />
        protected abstract HashAlgorithm HashAlgorithm { get; }

        /// <summary> 计算哈希。 </summary>
        /// <param name="input"> 需要计算的字节数组。 </param>
        /// <returns> 哈希计算后的字节数组。 </returns>
        public abstract byte[] ComputeHash(byte[] input);

        /// <summary> 计算哈希数据，并写入流 <paramref name="stream" />。 </summary>
        /// <param name="input"> 字节数组。 </param>
        /// <param name="stream">
        /// 目标流。
        /// <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
        /// </param>
        /// <seealso cref="Stream" />
        public abstract void ComputeHash(byte[] input, Stream stream);
    }
}