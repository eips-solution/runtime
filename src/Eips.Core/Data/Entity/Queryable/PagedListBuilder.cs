/* *************************************************************************************************************************************** *\
 * COPYRIGHT ? 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Collections.Generic;

namespace Niacomsoft.Eips.Data.Entity.Queryable
{
    /// <summary> �ṩ�˹��� <see cref="PagedListBuilder{TElement}" /> ���͵Ķ���ʵ����صķ����� </summary>
    /// <typeparam name="TElement"> ��ҳԪ�����͡� </typeparam>
    public class PagedListBuilder<TElement>
    {
        private IEnumerable<TElement> m_rows;
        private long m_totalCount;

        /// <summary> ���ڳ�ʼ��һ�� <see cref="PagedListBuilder{TElement}" /> ���͵Ķ���ʵ���� </summary>
        public PagedListBuilder() => Reset();

        /// <summary> ���� <see cref="PagedList{T}" /> ���͵Ķ���ʵ���� </summary>
        /// <returns> <see cref="PagedList{T}" /> ���͵Ķ���ʵ���� </returns>
        public PagedList<TElement> Build() => new PagedList<TElement>(m_rows, m_totalCount);

        /// <summary> ���� <see cref="PagedListBuilder{TElement}" /> ���͵Ķ���ʵ���� </summary>
        /// <returns> <see cref="PagedListBuilder{TElement}" /> ���͵Ķ���ʵ���� </returns>
        public PagedListBuilder<TElement> Reset()
        {
            m_rows = default;
            m_totalCount = default;

            return this;
        }

        /// <summary> ���� <typeparamref name="TElement" /> Ԫ�ؼ��ϡ� </summary>
        /// <param name="rows"> Ԫ�ؼ��ϡ� </param>
        /// <returns> <see cref="PagedListBuilder{TElement}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="IEnumerable{T}" />
        public PagedListBuilder<TElement> WithRows(IEnumerable<TElement> rows)
        {
            m_rows = rows;
            return this;
        }

        /// <summary> ����Ԫ���ܸ����� </summary>
        /// <param name="total"> Ԫ���ܸ����� </param>
        /// <returns> <see cref="PagedListBuilder{TElement}" /> ���͵Ķ���ʵ���� </returns>
        public PagedListBuilder<TElement> WithTotalElementsCount(long total = 0)
        {
            m_totalCount = total;
            return this;
        }
    }
}