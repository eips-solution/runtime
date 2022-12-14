/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.IO;

namespace Niacomsoft.Eips.Runtime.Serializations
{
    /// <summary> 定义了数据序列化的接口。 </summary>
    public interface ISerializer
    {
        /// <summary>
        /// 从流 <paramref name="deserializeStream" /> 中反序列化得到
        /// <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="deserializeStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <seealso cref="Stream" />
        T Deserialize<T>(Stream deserializeStream) where T : class, new();

        /// <summary>
        /// 从字节数据 <paramref name="input" /> 反序列化得到 <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="input"> 字节数组。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        T Deserialize<T>(byte[] input) where T : class, new();

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并写入流 <paramref name="serializeStream" />。 </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="obj"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <param name="serializeStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <seealso cref="Stream" />
        void Serialize<T>(T obj, Stream serializeStream) where T : class, new();

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并返回字节数据。 </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="obj"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <returns>
        /// 字节数组。
        /// <para>
        /// 当 <paramref name="obj" /> 等于 <c> null </c> 时，将返回 <c> null </c>。
        /// </para>
        /// </returns>
        byte[] Serialize<T>(T obj) where T : class, new();
    }
}