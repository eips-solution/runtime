/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Collections.Generic;
using System.Linq;

namespace Niacomsoft.Eips.Data.Entity.Queryable
{
    /// <summary> 提供了供分页的数据列表相关的方法。 </summary>
    /// <typeparam name="T"> 数据元素类型。 </typeparam>
    /// <seealso cref="IPagedList{T}" />
    public class PagedList<T> : IPagedList<T>
    {
        /// <summary> 用于初始化一个 <see cref="PagedList{T}" /> 类型的对象实例。 </summary>
        /// <param name="elements"> 元素集合。 </param>
        public PagedList(IEnumerable<T> elements) : this(elements, ReferenceTypeEqualityComparer.None(elements) ? 0 : elements.Count())
        {
        }

        /// <summary> 用于初始化一个 <see cref="PagedList{T}" /> 类型的对象实例。 </summary>
        /// <param name="elements"> 元素集合。 </param>
        /// <param name="total"> 元素总数量。 </param>
        public PagedList(IEnumerable<T> elements, long total)
        {
            TotalElementsCount = total;
            Elements = elements?.ToArray();
        }

        /// <summary> 用于初始化一个 <see cref="PagedList{T}" /> 类型的对象实例。 </summary>
        public PagedList() : this(null)
        {
        }

        /// <summary> 元素集合。 </summary>
        /// <value> 设置或获取 <typeparamref name="T" /> 类型的对象实例或值的集合，用于表示元素集合。 </value>
        /// <seealso cref="IEnumerable{T}" />
        IEnumerable<T> IPagedList<T>.Elements
        {
            get { return Elements; }
            set { Elements = value?.ToArray(); }
        }

        /// <summary> 元素集合。 </summary>
        /// <value> 设置或获取 <typeparamref name="T" /> 类型的对象实例或值的集合，用于表示元素集合。 </value>
        public virtual T[] Elements { get; set; }

        /// <summary> 元素总数量。 </summary>
        /// <value> 设置或获取一个值，用于表示元素总数量。 </value>
        public long TotalElementsCount { get; set; }
    }
}