/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips
{
    /// <summary>
    /// 提供了生成 <see cref="Guid" /> 类型 ID 相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IValueTypedIDGenerateUtilities{TValueType}" />
    /// <seealso cref="IIDGenerateUtilities{T}" />
    /// <seealso cref="Guid" />
    public sealed class GuidGenerator : IValueTypedIDGenerateUtilities<Guid>, IIDGenerateUtilities<Guid>
    {
        /// <summary> 产生一个新的 <see cref="Guid" /> 类型 ID。 </summary>
        /// <param name="args"> 生成新的 ID 所需的扩展参数。 </param>
        /// <returns> <see cref="Guid" /> 类型 ID。 </returns>
        public Guid NewId(params object[] args) => Guid.NewGuid();
    }
}