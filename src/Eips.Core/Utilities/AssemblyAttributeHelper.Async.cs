/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace Niacomsoft.Eips.Reflection
{
    public sealed partial class AssemblyAttributeHelper
    {
#if !NET40
        /// <summary> 异步访问程序集注解信息的方法。 </summary>
        /// <value> 获取 <see cref="AssemblyAttributeHelper" /> 类型的对象实例，用于表示异步访问程序集注解信息的方法。 </value>
        /// <seealso cref="IAsyncAttributeHelper{TTarget}" />
        public static IAsyncAttributeHelper<Assembly> AsynchronousInstance = new AssemblyAttributeHelper();

        /// <summary>
        /// (异步的方法) 获取 <paramref name="assm" /> 中
        /// <typeparamref name="TAttribute" /> 类型的注解。
        /// </summary>
        /// <param name="assm">
        /// 注解目标。
        /// <para> <see cref="Assembly" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <see cref="Assembly" /> 的继承链。 </param>
        /// <returns> <typeparamref name="TAttribute" /> 类型的对象实例。 </returns>
        /// <seealso cref="Attribute" />
        /// <seealso cref="Task{TResult}" />
        public override Task<TAttribute> GetCustomAttributeAsync<TAttribute>(Assembly assm, bool inherit = false)
        {
            return base.GetCustomAttributeAsync<TAttribute>(assm, inherit);
        }

        /// <summary> (异步的方法) 获取 <paramref name="assm" /> 所有的注解。 </summary>
        /// <param name="assm">
        /// 注解目标。
        /// <para> <see cref="Assembly" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <see cref="Assembly" /> 的继承链。 </param>
        /// <returns> <see cref="Attribute" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Attribute" />
        /// <seealso cref="Task{TResult}" />
        public override Task<IEnumerable<Attribute>> GetCustomAttributesAsync(Assembly assm, bool inherit = false)
        {
            return base.GetCustomAttributesAsync(assm, inherit);
        }

        /// <summary>
        /// (异步的方法) 获取 <paramref name="assm" /> 所有的
        /// <typeparamref name="TAttribute" /> 类型注解。
        /// </summary>
        /// <param name="assm">
        /// 注解目标。
        /// <para> <see cref="Assembly" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <see cref="Assembly" /> 的继承链。 </param>
        /// <returns> <typeparamref name="TAttribute" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Attribute" />
        /// <seealso cref="Task{TResult}" />
        public override Task<IEnumerable<TAttribute>> GetCustomAttributesAsync<TAttribute>(Assembly assm, bool inherit = false)
        {
            return base.GetCustomAttributesAsync<TAttribute>(assm, inherit);
        }
#endif
    }
}