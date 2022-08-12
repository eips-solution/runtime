/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Globalization;
using System;

namespace Niacomsoft.Eips
{
    /// <summary>
    /// 当在指定类型中未能找到指定的注解时，将引发此类型的异常。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="Exception" />
    public sealed class TypeAnnotationNotFoundException : Exception
    {
        /// <summary>
        /// 用于初始化一个 <see cref="TypeAnnotationNotFoundException" /> 类型的对象实例。
        /// </summary>
        /// <param name="target"> 注解目标类型。 </param>
        /// <param name="attrType"> 注解类型。 </param>
        public TypeAnnotationNotFoundException(Type target, Type attrType) 
            : base(SR.Format("TypeAnnotationNotFoundException_default_message", target.FullName, attrType.Name))
        {
            Target = target;
            AttributeType = attrType;
        }

        /// <summary> 注解类型。 </summary>
        /// <value> 获取 <see cref="Type" /> 类型的对象实例，用于表示注解类型。 </value>
        /// <seealso cref="Type" />
        public Type AttributeType { get; }

        /// <summary> 注解目标类型。 </summary>
        /// <value> 获取 <see cref="Type" /> 类型的对象实例，用于表示注解目标类型。 </value>
        /// <seealso cref="Type" />
        public Type Target { get; }
    }
}