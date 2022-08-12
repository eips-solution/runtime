/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Diagnostics;
using System;
using System.Diagnostics;
using System.IO;

namespace Niacomsoft.Eips.Runtime.Serializations
{
    /// <summary> 提供了数据序列化相关的基本方法。 </summary>
    /// <seealso cref="ISerializer" />
    public abstract class Serializer : ISerializer
    {
        /// <summary>
        /// 从流 <paramref name="deserializeStream" /> 中反序列化得到
        /// <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="deserializeStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <seealso cref="Stream" />
        public abstract T Deserialize<T>(Stream deserializeStream) where T : class, new();

        /// <summary>
        /// 从字节数据 <paramref name="input" /> 反序列化得到 <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="input"> 字节数组。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="input" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        public virtual T Deserialize<T>(byte[] input) where T : class, new()
        {
            if (ReferenceTypeEqualityComparer.None(input))
            {
                throw new ArgumentNullException(nameof(input));
            }

            using (var destinationStream = new MemoryStream(input))
            {
                destinationStream.Seek(0, SeekOrigin.Begin);
                return Deserialize<T>(destinationStream);
            }
        }

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并写入流 <paramref name="serializeStream" />。 </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="obj"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <param name="serializeStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <seealso cref="Stream" />
        public abstract void Serialize<T>(T obj, Stream serializeStream) where T : class, new();

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并返回字节数据。 </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="obj"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <returns>
        /// 字节数组。
        /// <para>
        /// 当 <paramref name="obj" /> 等于 <c> null </c> 时，将返回 <c> null </c>。
        /// </para>
        /// </returns>
        public virtual byte[] Serialize<T>(T obj) where T : class, new()
        {
            if (ReferenceTypeEqualityComparer.None(obj))
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget(GetType())
                                                             .WithMethod(nameof(Serialize))
                                                             .WithMessage($"“{typeof(T).FullName}” 类型的对象实例 “{nameof(obj)}” 等于 null，将返回 null 。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);
                return null;
            }
            using (var destinationStream = new MemoryStream())
            {
                Serialize<T>(obj, destinationStream);
                return destinationStream.ToArray();
            }
        }
    }
}