/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Queryable
{
    /// <summary> 定义了数据排序参数的接口。 </summary>
    public interface ISortParameter
    {
        /// <summary> 需要排序的字段。 </summary>
        /// <value> 设置或获取一个字符串数组，用于表示需要排序的字段。 </value>
        string[] Fields { get; set; }

        /// <summary> 排序方式。 </summary>
        /// <value> 设置或获取一个值，用于表示排序方式。 </value>
        /// <seealso cref="SortMode" />
        SortMode? Mode { get; set; }
    }
}