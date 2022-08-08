/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了标记数据实体首次创建时间的接口。 </summary>
    public interface ICreatedTime
    {
        /// <summary> 首次创建时间。 </summary>
        /// <value> 设置或获取一个值，用于表示首次创建时间。 </value>
        /// <seealso cref="DateTime" />
        DateTime CreatedTime { get; set; }

        /// <summary> 首次创建时间描述。 </summary>
        /// <value> 获取一个字符串，用于表示首次创建时间描述。 </value>
        string CreatedTimeDescription { get; }
    }
}