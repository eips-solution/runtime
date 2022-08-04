/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Niacomsoft.Eips
{
    /// <summary> 定义了异步的访问注解信息的接口。 </summary>
    /// <typeparam name="TTarget"> 注解目标类型。 </typeparam>
    /// <seealso cref="IAttributeHelper{TTarget}" />
    public interface IAsyncAttributeHelper<TTarget> : IAttributeHelper<TTarget>
        where TTarget : class
    {
        /// <summary>
        /// (异步的方法) 获取 <paramref name="target" /> 中
        /// <typeparamref name="TAttribute" /> 类型的注解。
        /// </summary>
        /// <typeparam name="TAttribute">
        /// 派生自 <see cref="Attribute" /> 的类型。
        /// </typeparam>
        /// <param name="target">
        /// 注解目标。
        /// <para> <typeparamref name="TTarget" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <typeparamref name="TTarget" /> 的继承链。 </param>
        /// <returns> <typeparamref name="TAttribute" /> 类型的对象实例。 </returns>
        /// <seealso cref="Attribute" />
        /// <seealso cref="Task{TResult}" />
        Task<TAttribute> GetCustomAttributeAsync<TAttribute>(TTarget target, bool inherit = false) 
            where TAttribute : Attribute;

        /// <summary> (异步的方法) 获取 <paramref name="target" /> 所有的注解。 </summary>
        /// <param name="target">
        /// 注解目标。
        /// <para> <typeparamref name="TTarget" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <typeparamref name="TTarget" /> 的继承链。 </param>
        /// <returns> <see cref="Attribute" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Attribute" />
        /// <seealso cref="Task{TResult}" />
        Task<IEnumerable<Attribute>> GetCustomAttributesAsync(TTarget target, bool inherit = false);

        /// <summary>
        /// (异步的方法) 获取 <paramref name="target" /> 所有的
        /// <typeparamref name="TAttribute" /> 类型注解。
        /// </summary>
        /// <typeparam name="TAttribute">
        /// 派生自 <see cref="Attribute" /> 的类型。
        /// </typeparam>
        /// <param name="target">
        /// 注解目标。
        /// <para> <typeparamref name="TTarget" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <typeparamref name="TTarget" /> 的继承链。 </param>
        /// <returns> <typeparamref name="TAttribute" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Attribute" />
        /// <seealso cref="Task{TResult}" />
        Task<IEnumerable<TAttribute>> GetCustomAttributesAsync<TAttribute>(TTarget target, bool inherit = false)
            where TAttribute : Attribute;
    }
}