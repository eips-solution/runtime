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
    public sealed partial class MemberAttributeHelper
    {
#if !NET40

        /// <summary> 异步访问成员注解信息的方法。 </summary>
        /// <value> 获取 <see cref="MemberAttributeHelper" /> 类型的对象实例，用于表示异步访问成员注解信息的方法。 </value>
        /// <seealso cref="IAsyncAttributeHelper{TTarget}" />
        /// <seealso cref="MemberInfo" />
        public static IAsyncAttributeHelper<MemberInfo> AsynchronousInstance => new MemberAttributeHelper();

        /// <summary>
        /// (异步的方法) 获取 <paramref name="member" /> 中
        /// <typeparamref name="TAttribute" /> 类型的注解。
        /// </summary>
        /// <typeparam name="TAttribute">
        /// 派生自 <see cref="Attribute" /> 的类型。
        /// </typeparam>
        /// <param name="member">
        /// 注解目标。
        /// <para> <see cref="MemberInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <see cref="MemberInfo" /> 的继承链。 </param>
        /// <returns> <typeparamref name="TAttribute" /> 类型的对象实例。 </returns>
        /// <seealso cref="Attribute" />
        /// <seealso cref="Task{TResult}" />
        public override Task<TAttribute> GetCustomAttributeAsync<TAttribute>(MemberInfo member, bool inherit = false)
        {
            return base.GetCustomAttributeAsync<TAttribute>(member, inherit);
        }

        /// <summary> (异步的方法) 获取 <paramref name="member" /> 所有的注解。 </summary>
        /// <param name="member">
        /// 注解目标。
        /// <para> <see cref="MemberInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <see cref="MemberInfo" /> 的继承链。 </param>
        /// <returns> <see cref="Attribute" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Attribute" />
        /// <seealso cref="Task{TResult}" />
        public override Task<IEnumerable<Attribute>> GetCustomAttributesAsync(MemberInfo member, bool inherit = false)
        {
            return base.GetCustomAttributesAsync(member, inherit);
        }

        /// <summary>
        /// (异步的方法) 获取 <paramref name="member" /> 所有的
        /// <typeparamref name="TAttribute" /> 类型注解。
        /// </summary>
        /// <typeparam name="TAttribute">
        /// 派生自 <see cref="Attribute" /> 的类型。
        /// </typeparam>
        /// <param name="member">
        /// 注解目标。
        /// <para> <see cref="MemberInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <see cref="MemberInfo" /> 的继承链。 </param>
        /// <returns> <typeparamref name="TAttribute" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Attribute" />
        /// <seealso cref="Task{TResult}" />
        public override Task<IEnumerable<TAttribute>> GetCustomAttributesAsync<TAttribute>(MemberInfo member, bool inherit = false)
        {
            return base.GetCustomAttributesAsync<TAttribute>(member, inherit);
        }

#endif
    }
}