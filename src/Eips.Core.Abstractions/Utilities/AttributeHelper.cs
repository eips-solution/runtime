/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Globalization;
using System;
using System.Collections.Generic;

namespace Niacomsoft.Eips
{
    /// <summary> 提供了访问注解信息相关的基本方法。 </summary>
    /// <typeparam name="TTarget"> 目标注解类型。 </typeparam>
    /// <seealso cref="IAttributeHelper{TTarget}" />
    public abstract class AttributeHelper<TTarget> : IAttributeHelper<TTarget>
        where TTarget : class
    {
        /// <summary>
        /// 当 <typeparamref name="TTarget" /> 等于 <c> null </c> 时，将引发一个
        /// <see cref="ArgumentNullException" /> 类型的异常。
        /// </summary>
        /// <param name="target"> <typeparamref name="TTarget" /> 类型的对象实例。 </param>
        protected void InvalidTarget(TTarget target)
        {
            if (ReferenceTypeEqualityComparer.None(target))
                throw new ArgumentNullException(nameof(target),
                                                SR.Format("ArgumentNullException_invalid_annotation_target", typeof(TTarget).FullName));
        }

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
        public abstract TAttribute GetCustomAttribute<TAttribute>(TTarget target, bool inherit = false)
            where TAttribute : Attribute;

        /// <summary> 获取 <paramref name="target" /> 所有的注解。 </summary>
        /// <param name="target">
        /// 注解目标。
        /// <para> <typeparamref name="TTarget" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <typeparamref name="TTarget" /> 的继承链。 </param>
        /// <returns> <see cref="Attribute" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Attribute" />
        public abstract IEnumerable<Attribute> GetCustomAttributes(TTarget target, bool inherit = false);

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
        public abstract IEnumerable<TAttribute> GetCustomAttributes<TAttribute>(TTarget target, bool inherit = false)
            where TAttribute : Attribute;
    }
}