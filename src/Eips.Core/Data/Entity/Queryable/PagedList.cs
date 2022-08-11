/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Collections.Generic;
using System.Linq;

namespace Niacomsoft.Eips.Data.Entity.Queryable
{
    /// <summary> 提供了供分页的数据列表相关的方法。 </summary>
    /// <typeparam name="TElement"> 数据元素类型。 </typeparam>
    /// <seealso cref="IPagedList{TElement}" />
    public class PagedList<TElement> : IPagedList<TElement>
    {
        /// <summary> 用于初始化一个 <see cref="PagedList{TElement}" /> 类型的对象实例。 </summary>
        /// <param name="rows"> 元素集合。 </param>
        public PagedList(IEnumerable<TElement> rows) : this(rows, ReferenceTypeEqualityComparer.None(rows) ? 0 : rows.Count())
        {
        }

        /// <summary> 用于初始化一个 <see cref="PagedList{TElement}" /> 类型的对象实例。 </summary>
        /// <param name="rows"> 元素集合。 </param>
        /// <param name="total"> 元素总数量。 </param>
        public PagedList(IEnumerable<TElement> rows, long total)
        {
            TotalRowsNumber = total;
            Rows = rows?.ToArray();
        }

        /// <summary> 用于初始化一个 <see cref="PagedList{TElement}" /> 类型的对象实例。 </summary>
        public PagedList() : this(null)
        {
        }

        /// <summary> 元素集合。 </summary>
        /// <value> 设置或获取 <typeparamref name="TElement" /> 类型的对象实例或值的集合，用于表示元素集合。 </value>
        public virtual TElement[] Rows { get; set; }

        /// <summary> 元素集合。 </summary>
        /// <value> 设置或获取 <typeparamref name="TElement" /> 类型的对象实例或值的集合，用于表示元素集合。 </value>
        /// <seealso cref="IEnumerable{T}" />
        IEnumerable<TElement> IPagedList<TElement>.Rows
        {
            get { return Rows; }
            set { Rows = value?.ToArray(); }
        }

        /// <summary> 元素总数量。 </summary>
        /// <value> 设置或获取一个值，用于表示元素总数量。 </value>
        public virtual long TotalRowsNumber { get; set; }
    }
}