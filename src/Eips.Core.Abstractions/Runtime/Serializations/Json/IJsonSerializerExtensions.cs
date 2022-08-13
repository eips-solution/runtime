﻿/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Runtime.Serializations.Json
{
    /// <summary> 定义了 JSON 序列化扩展方法接口。 </summary>
    /// <seealso cref="ISerializer" />
    public interface IJsonSerializerExtensions : ISerializer
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
        /// <see cref="string.Empty" /> 或者空格符时，则返回 <c> null </c>。
        /// </para>
        /// </returns>
        T DeserializeFromJsonString<T>(string jsonStr) where T : class, new();

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并获取 JSON 字符串。 </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="obj"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <returns>
        /// JSON 字符串。
        /// <para>
        /// 当 <paramref name="obj" /> 等于 <c> null </c> 时，则返回 <c> null </c>。
        /// </para>
        /// </returns>
        string SerializeToJsonString<T>(T obj) where T : class, new();
    }
}