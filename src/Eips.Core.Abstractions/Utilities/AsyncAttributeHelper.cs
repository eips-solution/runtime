/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Niacomsoft.Eips
{
#if !NET40
    /// <summary> 提供了异步访问注解信息相关的基本方法。 </summary>
    /// <typeparam name="TTarget"> </typeparam>
    /// <seealso cref="IAsyncAttributeHelper{TTarget}" />
    /// <seealso cref="AttributeHelper{TTarget}" />
    public abstract class AsyncAttributeHelper<TTarget> : AttributeHelper<TTarget>, IAsyncAttributeHelper<TTarget>
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
        public virtual Task<TAttribute> GetCustomAttributeAsync<TAttribute>(TTarget target, bool inherit = false) 
            where TAttribute : Attribute 
            => Task.Run(() => GetCustomAttribute<TAttribute>(target, inherit));

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
        public virtual Task<IEnumerable<Attribute>> GetCustomAttributesAsync(TTarget target, bool inherit = false) 
            => Task.Run(() => GetCustomAttributes(target, inherit));

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
        public virtual Task<IEnumerable<TAttribute>> GetCustomAttributesAsync<TAttribute>(TTarget target, bool inherit = false)
            where TAttribute : Attribute 
            => Task.Run(() => GetCustomAttributes<TAttribute>(target, inherit));
    }
#endif
}