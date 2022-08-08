/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Queryable
{
    /// <summary> 定义了分页查询参数的接口。 </summary>
    public interface IPagedParameter
    {
        /// <summary> 需要查询的当前页索引数字。 </summary>
        /// <value> 设置或获取一个值，用于表示需要查询的当前页索引数字。 </value>
        int CurrentIndex { get; set; }

        /// <summary> 每页数据行数。 </summary>
        /// <value> 设置或获取一个值，用于表示每页数据行数。 </value>
        int PerPageSize { get; set; }
    }
}