/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了标识数据实体最后一次修改时间的接口。 </summary>
    /// <seealso cref="ICreatedTime" />
    public interface IModifiedTime : ICreatedTime
    {
        /// <summary> 是否被修改过。 </summary>
        /// <value>
        /// 获取一个值，用于表示是否被修改过。
        /// <para>
        /// 当 <see cref="LatestModifiedTime" />.HasValue 等于 <c> false </c> 时，返回
        /// <c> true </c>；否则返回 <c> false </c>。
        /// </para>
        /// </value>
        bool IsModified { get; }

        /// <summary> 最后一次的修改时间。 </summary>
        /// <value> 设置或获取一个值，用于表示最后一次的修改时间。 </value>
        /// <seealso cref="DateTime" />
        /// <seealso cref="Nullable{T}" />
        DateTime? LatestModifiedTime { get; set; }

        /// <summary> 最后一次的修改时间描述。 </summary>
        /// <value> 获取一个字符串，用于表示最后一次的修改时间描述。 </value>
        string LatestModifiedTimeDescription { get; }
    }
}