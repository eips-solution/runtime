/* *************************************************************************************************************************************** *\
 * COPYRIGHT ? 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips.Data.Entity
{
    /// <summary> �ṩ�˹��� <see cref="IDbResult"/> ��صķ����� </summary> 
    /// <seealso cref="IDbResult"/> 
    /// <seealso cref="IDbResult{T}"/>
    public class DbResultBuilder
    {
        private bool m_completed;
        private System.Exception m_exception;

        /// <summary> ���ڳ�ʼ��һ�� <see cref="DbResultBuilder" /> ���͵Ķ���ʵ���� </summary>
        public DbResultBuilder() => Reset();

        /// <summary> �������ݿ����� </summary>
        /// <returns> ʵ���� <see cref="IDbResult" /> ���ͽӿڵĶ���ʵ���� </returns>
        /// <seealso cref="IDbResult" />
        /// <seealso cref="DbResult" />
        public IDbResult Build() => new DbResult(m_completed, m_exception);

        /// <summary> �������ݿ����� </summary>
        /// <typeparam name="T"> ���ݽ�����͡� </typeparam>
        /// <param name="result"> ���ݽ���� </param>
        /// <returns> ʵ���� <see cref="IDbResult{T}" /> ���ͽӿڵĶ���ʵ���� </returns>
        /// <seealso cref="IDbResult" />
        /// <seealso cref="IDbResult{T}" />
        /// <seealso cref="DbResult" />
        /// <seealso cref="DbResult{T}" />
        public IDbResult<T> Build<T>(T result) => new DbResult<T>(m_completed, m_exception) { Result = result };

        /// <summary> ���� <see cref="DbResultBuilder" /> ���͵Ķ���ʵ���� </summary>
        /// <returns> <see cref="DbResultBuilder" /> ���͵Ķ���ʵ���� </returns>
        public DbResultBuilder Reset()
        {
            m_completed = true;
            m_exception = null;

            return this;
        }

        /// <summary> �������ݿ������Ƿ�ִ�гɹ��� </summary>
        /// <param name="value"> �Ƿ�ִ�гɹ��� </param>
        /// <returns> <see cref="DbResultBuilder" /> ���͵Ķ���ʵ���� </returns>
        public DbResultBuilder WithCompleted(bool value = true)
        {
            m_completed = value;
            return this;
        }

        /// <summary> �������ݿ�����ִ�й����е��쳣�� </summary>
        /// <param name="exception"> ������ <see cref="Exception" /> ���͵Ķ���ʵ���� </param>
        /// <returns> <see cref="DbResultBuilder" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Exception" />
        public DbResultBuilder WithExecutionException(Exception exception = null)
        {
            m_exception = exception;
            return this;
        }
    }
}