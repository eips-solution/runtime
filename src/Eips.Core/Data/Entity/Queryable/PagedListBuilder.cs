/* *************************************************************************************************************************************** *\
 * COPYRIGHT ? 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Collections.Generic;

namespace Niacomsoft.Eips.Data.Entity.Queryable
{
    /// <summary> �ṩ�˹��� <see cref="PagedListBuilder{T}" /> ���͵Ķ���ʵ����صķ����� </summary>
    /// <typeparam name="T"> ��ҳԪ�����͡� </typeparam>
    public class PagedListBuilder<T>
    {
        private IEnumerable<T> m_elements;
        private long m_totalCount;

        /// <summary> ���ڳ�ʼ��һ�� <see cref="PagedListBuilder{T}" /> ���͵Ķ���ʵ���� </summary>
        public PagedListBuilder() => Reset();

        /// <summary> ���� <see cref="PagedList{T}" /> ���͵Ķ���ʵ���� </summary>
        /// <returns> <see cref="PagedList{T}" /> ���͵Ķ���ʵ���� </returns>
        public PagedList<T> Build() => new PagedList<T>(m_elements, m_totalCount);

        /// <summary> ���� <see cref="PagedListBuilder{T}" /> ���͵Ķ���ʵ���� </summary>
        /// <returns> <see cref="PagedListBuilder{T}" /> ���͵Ķ���ʵ���� </returns>
        public PagedListBuilder<T> Reset()
        {
            m_elements = default;
            m_totalCount = default;

            return this;
        }

        /// <summary> ���� <typeparamref name="T" /> Ԫ�ؼ��ϡ� </summary>
        /// <param name="elements"> Ԫ�ؼ��ϡ� </param>
        /// <returns> <see cref="PagedListBuilder{T}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="IEnumerable{T}" />
        public PagedListBuilder<T> WithElements(IEnumerable<T> elements)
        {
            m_elements = elements;
            return this;
        }

        /// <summary> ����Ԫ���ܸ����� </summary>
        /// <param name="total"> Ԫ���ܸ����� </param>
        /// <returns> <see cref="PagedListBuilder{T}" /> ���͵Ķ���ʵ���� </returns>
        public PagedListBuilder<T> WithTotalElementsCount(long total = 0)
        {
            m_totalCount = total;
            return this;
        }
    }
}