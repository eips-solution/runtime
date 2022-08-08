/* *************************************************************************************************************************************** *\
 * COPYRIGHT ? 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Collections.Generic;

namespace Niacomsoft.Eips.Data.Entity.Queryable
{
    /// <summary> 提供了构建 <see cref="PagedListBuilder{T}" /> 类型的对象实例相关的方法。 </summary>
    /// <typeparam name="T"> 分页元素类型。 </typeparam>
    public class PagedListBuilder<T>
    {
        private IEnumerable<T> m_elements;
        private long m_totalCount;

        /// <summary> 用于初始化一个 <see cref="PagedListBuilder{T}" /> 类型的对象实例。 </summary>
        public PagedListBuilder() => Reset();

        /// <summary> 构建 <see cref="PagedList{T}" /> 类型的对象实例。 </summary>
        /// <returns> <see cref="PagedList{T}" /> 类型的对象实例。 </returns>
        public PagedList<T> Build() => new PagedList<T>(m_elements, m_totalCount);

        /// <summary> 重置 <see cref="PagedListBuilder{T}" /> 类型的对象实例。 </summary>
        /// <returns> <see cref="PagedListBuilder{T}" /> 类型的对象实例。 </returns>
        public PagedListBuilder<T> Reset()
        {
            m_elements = default;
            m_totalCount = default;

            return this;
        }

        /// <summary> 设置 <typeparamref name="T" /> 元素集合。 </summary>
        /// <param name="elements"> 元素集合。 </param>
        /// <returns> <see cref="PagedListBuilder{T}" /> 类型的对象实例。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        public PagedListBuilder<T> WithElements(IEnumerable<T> elements)
        {
            m_elements = elements;
            return this;
        }

        /// <summary> 设置元素总个数。 </summary>
        /// <param name="total"> 元素总个数。 </param>
        /// <returns> <see cref="PagedListBuilder{T}" /> 类型的对象实例。 </returns>
        public PagedListBuilder<T> WithTotalElementsCount(long total = 0)
        {
            m_totalCount = total;
            return this;
        }
    }
}