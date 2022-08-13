/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Newtonsoft.Json;
using Niacomsoft.Eips.Runtime.Serializations;
using Niacomsoft.Eips.Runtime.Serializations.Json;

namespace Niacomsoft.Eips.Extensions.Runtime.Serializations
{
    /// <summary>
    /// 提供了基于 <see cref="Newtonsoft.Json" /> JSON 序列化相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="Serializer" />
    /// <seealso cref="Newtonsoft.Json" href="https://www.nuget.org/packages/Newtonsoft.Json" />
    public sealed class JsonSerializer : JsonSerializerExtensions
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
        protected override T InternalDeserializeFromJsonString<T>(string jsonStr)
            => JsonConvert.DeserializeObject(jsonStr, DefaultJsonSerializerSettings.Default) as T;

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并获取 JSON 字符串。 </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="obj"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <returns>
        /// JSON 字符串。
        /// <para>
        /// 当 <paramref name="obj" /> 等于 <c> null </c> 时，则返回 <c> null </c>。
        /// </para>
        /// </returns>
        protected override string InternalSerializeToJsonString<T>(T obj)
            => JsonConvert.SerializeObject(obj, DefaultJsonSerializerSettings.Default);
    }
}