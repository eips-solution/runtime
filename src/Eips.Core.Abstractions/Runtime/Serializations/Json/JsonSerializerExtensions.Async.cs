/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Threading.Tasks;

namespace Niacomsoft.Eips.Runtime.Serializations.Json
{
#if !NET40
    public abstract partial class JsonSerializerExtensions : IAsyncJsonSerializerExtensions
    {
        /// <summary>
        /// (异步的方法) 从 JSON 字符串 <paramref name="jsonStr" /> 反序列化得到
        /// <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="jsonStr"> JSON 字符串。 </param>
        /// <returns>
        /// <typeparamref name="T" /> 类型的对象实例。
        /// <para>
        /// 当 <paramref name="jsonStr" /> 等于 <c> null </c>、g
        /// <see cref="F:System.String.Empty" /> 或者空格符时，则返回 <c> null </c>。
        /// </para>
        /// </returns>
        /// <seealso cref="Task{TResult}" />
        public Task<T> DeserializeFromJsonStringAsync<T>(string jsonStr) where T : class, new()
            => Task.Run(() => DeserializeFromJsonString<T>(jsonStr));

        /// <summary>
        /// (异步的方法) 序列化 <typeparamref name="T" /> 类型的对象实例，并获取 JSON 字符串。
        /// </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="obj"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <returns>
        /// JSON 字符串。
        /// <para>
        /// 当 <paramref name="obj" /> 等于 <c> null </c> 时，则返回 <c> null </c>。
        /// </para>
        /// </returns>
        /// <seealso cref="Task{TResult}" />
        public Task<string> SerializeToJsonStringAsync<T>(T obj) where T : class, new()
            => Task.Run(() => SerializeToJsonString(obj));
    }
#endif
}