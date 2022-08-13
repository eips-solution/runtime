/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Diagnostics;
using System;
using System.Diagnostics;
using System.IO;

namespace Niacomsoft.Eips.Runtime.Serializations.Json
{
    /// <summary> 提供了 JSON 序列化扩展相关的方法。 </summary>
    /// <seealso cref="IJsonSerializerExtensions" />
    /// <seealso cref="Serializer" />
    public abstract partial class JsonSerializerExtensions : Serializer, IJsonSerializerExtensions
    {
        /// <summary>
        /// 从 JSON 字符串 <paramref name="jsonStr" /> 反序列化得到
        /// <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="jsonStr"> JSON 字符串。 </param>
        /// <returns>
        /// <typeparamref name="T" /> 类型的对象实例。
        /// <para>
        /// 当 <paramref name="jsonStr" /> 等于 <c> null </c>、
        /// <see cref="F:System.String.Empty" /> 或者空格符时，则返回 <c> null </c>。
        /// </para>
        /// </returns>
        protected abstract T InternalDeserializeFromJsonString<T>(string jsonStr) where T : class, new();

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并获取 JSON 字符串。 </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="obj"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <returns>
        /// JSON 字符串。
        /// <para>
        /// 当 <paramref name="obj" /> 等于 <c> null </c> 时，则返回 <c> null </c>。
        /// </para>
        /// </returns>
        protected abstract string InternalSerializeToJsonString<T>(T obj) where T : class, new();

        /// <summary>
        /// 从字节数据 <paramref name="input" /> 反序列化得到 <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="input"> 字节数组。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        public override T Deserialize<T>(byte[] input)
            => DeserializeFromJsonString<T>(StringUtilities.GetString(input));

        /// <summary>
        /// 从流 <paramref name="deserializeStream" /> 中反序列化得到
        /// <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="deserializeStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <seealso cref="Stream" />
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="deserializeStream" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        public override T Deserialize<T>(Stream deserializeStream)
        {
            if (deserializeStream is null)
            {
                throw new ArgumentNullException(nameof(deserializeStream));
            }
            using (var reader = new StreamReader(deserializeStream))
            {
                return DeserializeFromJsonString<T>(reader.ReadToEnd());
            }
        }

        /// <summary>
        /// 从 JSON 字符串 <paramref name="jsonStr" /> 反序列化得到
        /// <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="jsonStr"> JSON 字符串。 </param>
        /// <returns>
        /// <typeparamref name="T" /> 类型的对象实例。
        /// <para>
        /// 当 <paramref name="jsonStr" /> 等于 <c> null </c>、
        /// <see cref="F:System.String.Empty" /> 或者空格符时，则返回 <c> null </c>。
        /// </para>
        /// </returns>
        public virtual T DeserializeFromJsonString<T>(string jsonStr) where T : class, new()
        {
            if (StringEqualityComparer.Empty(jsonStr))
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget(GetType())
                                                             .WithMethod(nameof(DeserializeFromJsonString))
                                                             .WithMessage($"JSON 字符串 “{nameof(jsonStr)}” 等于 null、string.Empty 或者空格符，将返回 null。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);
                return null;
            }
            return InternalDeserializeFromJsonString<T>(jsonStr);
        }

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并返回字节数据。 </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="obj"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <returns>
        /// 字节数组。
        /// <para>
        /// 当 <paramref name="obj" /> 等于 <c> null </c> 时，将返回 <c> null </c>。
        /// </para>
        /// </returns>
        public override byte[] Serialize<T>(T obj)
        {
            var jsonStr = SerializeToJsonString(obj);
            if (StringEqualityComparer.Empty(jsonStr, EmptyCompareOptions.OnlyNull)) return null;
            return StringUtilities.GetBytes(jsonStr);
        }

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并写入流 <paramref name="serializeStream" />。 </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="obj"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <param name="serializeStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <seealso cref="Stream" />
        public override void Serialize<T>(T obj, Stream serializeStream)
        {
            var bytes = Serialize<T>(obj);
            if (ReferenceTypeEqualityComparer.NotNone(bytes))
                serializeStream.Write(bytes, 0, bytes.Length);
        }

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并获取 JSON 字符串。 </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="obj"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <returns>
        /// JSON 字符串。
        /// <para>
        /// 当 <paramref name="obj" /> 等于 <c> null </c> 时，则返回 <c> null </c>。
        /// </para>
        /// </returns>
        public virtual string SerializeToJsonString<T>(T obj) where T : class, new()
        {
            if (ReferenceTypeEqualityComparer.None(obj))
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget(GetType())
                                                             .WithMethod(nameof(SerializeToJsonString))
                                                             .WithMessage($"“{typeof(T).FullName}” 类型的参数 “{nameof(obj)}” 等于 null，无法执行 JSON 序列化，将返回 null。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);

                return null;
            }

            return InternalSerializeToJsonString(obj);
        }
    }
}