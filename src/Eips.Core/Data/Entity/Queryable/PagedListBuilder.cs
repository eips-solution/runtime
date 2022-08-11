/* *************************************************************************************************************************************** *\
 * COPYRIGHT ? 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Collections.Generic;

namespace Niacomsoft.Eips.Data.Entity.Queryable
{
    /// <summary> 提供了构建 <see cref="PagedListBuilder{TElement}" /> 类型的对象实例相关的方法。 </summary>
    /// <typeparam name="TElement"> 分页元素类型。 </typeparam>
    public class PagedListBuilder<TElement>
    {
        private IEnumerable<TElement> m_rows;
        private long m_totalCount;

        /// <summary> 用于初始化一个 <see cref="PagedListBuilder{TElement}" /> 类型的对象实例。 </summary>
        public PagedListBuilder() => Reset();

        /// <summary> 构建 <see cref="PagedList{T}" /> 类型的对象实例。 </summary>
        /// <returns> <see cref="PagedList{T}" /> 类型的对象实例。 </returns>
        public PagedList<TElement> Build() => new PagedList<TElement>(m_rows, m_totalCount);

        /// <summary> 重置 <see cref="PagedListBuilder{TElement}" /> 类型的对象实例。 </summary>
        /// <returns> <see cref="PagedListBuilder{TElement}" /> 类型的对象实例。 </returns>
        public PagedListBuilder<TElement> Reset()
        {
            m_rows = default;
            m_totalCount = default;

            return this;
        }

        /// <summary> 设置 <typeparamref name="TElement" /> 元素集合。 </summary>
        /// <param name="rows"> 元素集合。 </param>
        /// <returns> <see cref="PagedListBuilder{TElement}" /> 类型的对象实例。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        public PagedListBuilder<TElement> WithRows(IEnumerable<TElement> rows)
        {
            m_rows = rows;
            return this;
        }

        /// <summary> 设置元素总个数。 </summary>
        /// <param name="total"> 元素总个数。 </param>
        /// <returns> <see cref="PagedListBuilder{TElement}" /> 类型的对象实例。 </returns>
        public PagedListBuilder<TElement> WithTotalElementsCount(long total = 0)
        {
            m_totalCount = total;
            return this;
        }
    }
}