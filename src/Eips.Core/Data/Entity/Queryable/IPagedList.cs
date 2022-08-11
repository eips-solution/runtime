/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Collections.Generic;

namespace Niacomsoft.Eips.Data.Entity.Queryable
{
    /// <summary> 定义了供分页的数据列表结果接口。 </summary>
    /// <typeparam name="TElement"> 元素类型。 </typeparam>
    public interface IPagedList<TElement>
    {
        /// <summary> 元素集合。 </summary>
        /// <value> 设置或获取 <typeparamref name="TElement" /> 类型的对象实例或值的集合，用于表示元素集合。 </value>
        /// <seealso cref="IEnumerable{T}" />
        IEnumerable<TElement> Rows { get; set; }

        /// <summary> 元素总数量。 </summary>
        /// <value> 设置或获取一个值，用于表示元素总数量。 </value>
        long TotalRowsNumber { get; set; }
    }
}