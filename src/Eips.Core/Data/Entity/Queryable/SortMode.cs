/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Queryable
{
    /// <summary> 定义了数据排序方式枚举类型。 </summary>
    public enum SortMode
    {
        /// <summary> 升序排序。 </summary>
        Ascending = 1,

        /// <summary> 降序排序。 </summary>
        Descending = 2,

        /// <summary> 默认的排序方式。等效于 <see cref="Descending" />。 </summary>
        Default = Descending
    }
}