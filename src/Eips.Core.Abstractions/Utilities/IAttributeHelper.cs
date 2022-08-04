/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;
using System.Collections.Generic;

namespace Niacomsoft.Eips
{
    /// <summary> 定义了注解 <see cref="Attribute" /> 相关的接口。 </summary>
    /// <typeparam name="TTarget"> 注解目标类型。 </typeparam>
    public interface IAttributeHelper<TTarget> where TTarget : class
    {
        /// <summary>
        /// 获取 <paramref name="target" /> 中 <typeparamref name="TAttribute" /> 类型的注解。
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
        TAttribute GetCustomAttribute<TAttribute>(TTarget target, bool inherit = false) where TAttribute : Attribute;

        /// <summary> 获取 <paramref name="target" /> 所有的注解。 </summary>
        /// <param name="target">
        /// 注解目标。
        /// <para> <typeparamref name="TTarget" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <typeparamref name="TTarget" /> 的继承链。 </param>
        /// <returns> <see cref="Attribute" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Attribute" />
        IEnumerable<Attribute> GetCustomAttributes(TTarget target, bool inherit = false);

        /// <summary>
        /// 获取 <paramref name="target" /> 所有的 <typeparamref name="TAttribute" /> 类型注解。
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
        IEnumerable<TAttribute> GetCustomAttributes<TAttribute>(TTarget target, bool inherit = false) where TAttribute : Attribute;
    }
}