/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.IO;
using System.Threading.Tasks;

namespace Niacomsoft.Eips.Runtime.Serializations
{
#if !NET40
    public abstract partial class Serializer : IAsyncSerializer
    {
        /// <summary>
        /// (异步的方法) 从流 <paramref name="deserializeStream" /> 中反序列化得到
        /// <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="deserializeStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <seealso cref="Stream" />
        /// <seealso cref="Task{TResult}" />
        public virtual Task<T> DeserializeAsync<T>(Stream deserializeStream) where T : class, new()
            => Task.Run(() => Deserialize<T>(deserializeStream));

        /// <summary>
        /// (异步的方法) 从字节数据 <paramref name="input" /> 反序列化得到
        /// <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="input"> 字节数组。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <seealso cref="Task{TResult}" />
        public virtual Task<T> DeserializeAsync<T>(byte[] input) where T : class, new()
            => Task.Run(() => Deserialize<T>(input));

        /// <summary>
        /// (异步的方法) 序列化 <typeparamref name="T" /> 类型的对象实例，并写入流 <paramref name="serializeStream" />。
        /// </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="obj"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <param name="serializeStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <see cref="Task" /> 类型的对象实例。 </returns>
        /// <seealso cref="Stream" />
        /// <seealso cref="Task" />
        public virtual Task SerializeAsync<T>(T obj, Stream serializeStream) where T : class, new()
            => Task.Run(() => Serialize(obj, serializeStream));

        /// <summary> (异步的方法) 序列化 <typeparamref name="T" /> 类型的对象实例，并返回字节数据。 </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="obj"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <returns>
        /// 字节数组。
        /// <para>
        /// 当 <paramref name="obj" /> 等于 <c> null </c> 时，将返回 <c> null </c>。
        /// </para>
        /// </returns>
        /// <seealso cref="Task{TResult}" />
        public virtual Task<byte[]> SerializeAsync<T>(T obj) where T : class, new() => Task.Run(() => Serialize(obj));
    }
#endif
}