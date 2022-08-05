/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Niacomsoft.Eips.Reflection
{
    /// <summary>
    /// 提供了访问程序集注解信息相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IAttributeHelper{TTarget}" />
    /// <seealso cref="IAsyncAttributeHelper{TTarget}" />
    /// <seealso cref="AttributeHelper{TTarget}" />
    /// <seealso cref="AsyncAttributeHelper{TTarget}" />
    /// <seealso cref="Assembly" />
    #if !NET40
    public sealed partial class AssemblyAttributeHelper : AsyncAttributeHelper<Assembly>, IAsyncAttributeHelper<Assembly>, IAttributeHelper<Assembly>
#else
    public sealed partial class AssemblyAttributeHelper : AttributeHelper<Assembly>, IAttributeHelper<Assembly>
#endif
    {
        /// <summary> 访问程序集注解信息的方法。 </summary>
        /// <value> 获取 <see cref="AssemblyAttributeHelper" /> 类型的对象实例，用于表示访问程序集注解信息的方法。 </value>
        /// <seealso cref="IAttributeHelper{TTarget}" />
        public static IAttributeHelper<Assembly> Instance => new AssemblyAttributeHelper();

        /// <summary>
        /// 获取 <paramref name="assm" /> 中 <typeparamref name="TAttribute" /> 类型的注解。
        /// </summary>
        /// <param name="assm">
        /// 注解目标。
        /// <para> <see cref="Assembly" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <see cref="Assembly" /> 的继承链。 </param>
        /// <returns> <typeparamref name="TAttribute" /> 类型的对象实例。 </returns>
        /// <seealso cref="Attribute" />
        /// <exception cref="AmbiguousMatchException">
        /// 当调用
        /// <see cref="Attribute.GetCustomAttribute(Assembly, Type, bool)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        public override TAttribute GetCustomAttribute<TAttribute>(Assembly assm, bool inherit = false)
        {
            InvalidTarget(assm);

            return Attribute.GetCustomAttribute(assm, typeof(TAttribute), inherit) as TAttribute;
        }

        /// <summary> 获取 <paramref name="assm" /> 所有的注解。 </summary>
        /// <param name="assm">
        /// 注解目标。
        /// <para> <see cref="Assembly" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <see cref="Assembly" /> 的继承链。 </param>
        /// <returns> <see cref="Attribute" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Attribute" />
        public override IEnumerable<Attribute> GetCustomAttributes(Assembly assm, bool inherit = false)
        {
            InvalidTarget(assm);

            return Attribute.GetCustomAttributes(assm, inherit);
        }

        /// <summary>
        /// 获取 <paramref name="assm" /> 所有的 <typeparamref name="TAttribute" /> 类型注解。
        /// </summary>
        /// <param name="assm">
        /// 注解目标。
        /// <para> <see cref="Assembly" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <see cref="Assembly" /> 的继承链。 </param>
        /// <returns> <typeparamref name="TAttribute" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Attribute" />
        public override IEnumerable<TAttribute> GetCustomAttributes<TAttribute>(Assembly assm, bool inherit = false)
        {
            InvalidTarget(assm);

            return Attribute.GetCustomAttributes(assm, typeof(TAttribute), inherit)
                            .Select(item => item as TAttribute)
                            .ToArray();
        }
    }
}