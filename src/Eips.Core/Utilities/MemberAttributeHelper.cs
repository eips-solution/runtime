﻿/* *************************************************************************************************************************************** *\
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
    /// 提供了访问成员注解信息相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IAttributeHelper{TTarget}" />
    /// <seealso cref="IAsyncAttributeHelper{TTarget}" />
    /// <seealso cref="AttributeHelper{TTarget}" />
    /// <seealso cref="MemberInfo" />
#if !NET40
    public sealed partial class MemberAttributeHelper : AsyncAttributeHelper<MemberInfo>, IAsyncAttributeHelper<MemberInfo>, IAttributeHelper<MemberInfo>
#else

    public sealed partial class MemberAttributeHelper : AttributeHelper<MemberInfo>, IAttributeHelper<MemberInfo>
#endif
    {
        /// <summary> 访问成员注解信息的方法。 </summary>
        /// <value> 获取 <see cref="MemberAttributeHelper" /> 类型的对象实例，用于表示访问成员注解信息的方法。 </value>
        /// <seealso cref="IAttributeHelper{TTarget}" />
        /// <seealso cref="MemberInfo"/>
        public static IAttributeHelper<MemberInfo> Instance => new MemberAttributeHelper();

        /// <summary>
        /// 获取 <paramref name="member" /> 中 <typeparamref name="TAttribute" /> 类型的注解。
        /// </summary>
        /// <param name="member">
        /// 注解目标。
        /// <para> <see cref="MemberInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <see cref="MemberInfo" /> 的继承链。 </param>
        /// <returns> <typeparamref name="TAttribute" /> 类型的对象实例。 </returns>
        /// <seealso cref="Attribute" />
        /// <exception cref="NotSupportedException">
        /// 当调用
        /// <see cref="Attribute.GetCustomAttribute(MemberInfo, Type, bool)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        /// <exception cref="AmbiguousMatchException">
        /// 当调用
        /// <see cref="Attribute.GetCustomAttribute(MemberInfo, Type, bool)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        /// <exception cref="TypeLoadException">
        /// 当调用
        /// <see cref="Attribute.GetCustomAttribute(MemberInfo, Type, bool)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        public override TAttribute GetCustomAttribute<TAttribute>(MemberInfo member, bool inherit = false)
        {
            InvalidTarget(member);

            return Attribute.GetCustomAttribute(member, typeof(TAttribute), inherit) as TAttribute;
        }

        /// <summary> 获取 <paramref name="member" /> 所有的注解。 </summary>
        /// <param name="member">
        /// 注解目标。
        /// <para> <see cref="MemberInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <see cref="MemberInfo" /> 的继承链。 </param>
        /// <returns> <see cref="Attribute" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Attribute" />
        /// <exception cref="NotSupportedException">
        /// 当调用 <see cref="Attribute.GetCustomAttributes(MemberInfo, bool)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        /// <exception cref="TypeLoadException">
        /// 当调用 <see cref="Attribute.GetCustomAttributes(MemberInfo, bool)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        public override IEnumerable<Attribute> GetCustomAttributes(MemberInfo member, bool inherit = false)
        {
            InvalidTarget(member);

            return Attribute.GetCustomAttributes(member, inherit);
        }

        /// <summary>
        /// 获取 <paramref name="member" /> 所有的 <typeparamref name="TAttribute" /> 类型注解。
        /// </summary>
        /// <param name="member">
        /// 注解目标。
        /// <para> <see cref="MemberInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="inherit"> 是否检索 <see cref="MemberInfo" /> 的继承链。 </param>
        /// <returns> <typeparamref name="TAttribute" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Attribute" />
        /// <exception cref="NotSupportedException">
        /// 当调用 <see cref="Attribute.GetCustomAttributes(MemberInfo, bool)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        /// <exception cref="TypeLoadException">
        /// 当调用 <see cref="Attribute.GetCustomAttributes(MemberInfo, bool)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        public override IEnumerable<TAttribute> GetCustomAttributes<TAttribute>(MemberInfo member, bool inherit = false)
        {
            InvalidTarget(member);

            return Attribute.GetCustomAttributes(member, typeof(TAttribute), inherit).Select(item => item as TAttribute).ToArray();
        }
    }
}