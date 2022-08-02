/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Globalization;
using System;

namespace Niacomsoft.Eips
{
    /// <summary>
    /// 当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法动态创建对象实例时，可能引发此类型的异常。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="Exception" />
    [Serializable]
    public sealed class DynamicCreateObjectInstanceException : Exception
    {
        /// <summary>
        /// 用于初始化一个 <see cref="DynamicCreateObjectInstanceException" /> 类型的对象实例。
        /// </summary>
        /// <param name="referenceType"> 引用类型。 </param>
        /// <param name="innerException">
        /// 引发此异常的 <see cref="Exception" /> 类型的对象实例。
        /// </param>
        public DynamicCreateObjectInstanceException(Type referenceType, Exception innerException)
            : base(SR.Format("DynamicCreateObjectInstanceException_default_message", referenceType.AssemblyQualifiedName),
                   innerException)
        {
            TargetType = referenceType;
        }

        /// <summary> 目标引用类型。 </summary>
        /// <value> 获取 <see cref="Type" /> 类型的对象实例，用于表示目标引用类型。 </value>
        /// <seealso cref="Type" />
        public Type TargetType { get; }
    }
}