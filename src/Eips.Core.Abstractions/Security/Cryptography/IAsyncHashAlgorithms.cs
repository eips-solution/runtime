/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.IO;
using System.Threading.Tasks;

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 提供了哈希算法相关的异步方法。 </summary>
    /// <seealso cref="IHashAlgorithms" />
    public interface IAsyncHashAlgorithms : IHashAlgorithms
    {
        /// <summary> (异步的方法) 计算哈希。 </summary>
        /// <param name="input"> 需要计算的字节数组。 </param>
        /// <returns> 哈希计算后的字节数组。 </returns>
        /// <seealso cref="Task{TResult}" />
        Task<byte[]> ComputeHashAsync(byte[] input);

        /// <summary> (异步的方法) 计算哈希数据，并写入流 <paramref name="stream" />。 </summary>
        /// <param name="input"> 字节数组。 </param>
        /// <param name="stream">
        /// 目标流。
        /// <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
        /// </param>
        /// <seealso cref="Stream" />
        /// <seealso cref="Task" />
        Task ComputeHashAsync(byte[] input, Stream stream);
    }
}