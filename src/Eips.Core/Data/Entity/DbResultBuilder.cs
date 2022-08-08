/* *************************************************************************************************************************************** *\
 * COPYRIGHT ? 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips.Data.Entity
{
    /// <summary> 提供了构建 <see cref="IDbResult"/> 相关的方法。 </summary> 
    /// <seealso cref="IDbResult"/> 
    /// <seealso cref="IDbResult{T}"/>
    public class DbResultBuilder
    {
        private bool m_completed;
        private System.Exception m_exception;

        /// <summary> 用于初始化一个 <see cref="DbResultBuilder" /> 类型的对象实例。 </summary>
        public DbResultBuilder() => Reset();

        /// <summary> 构建数据库结果。 </summary>
        /// <returns> 实现了 <see cref="IDbResult" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IDbResult" />
        /// <seealso cref="DbResult" />
        public IDbResult Build() => new DbResult(m_completed, m_exception);

        /// <summary> 构建数据库结果。 </summary>
        /// <typeparam name="T"> 数据结果类型。 </typeparam>
        /// <param name="result"> 数据结果。 </param>
        /// <returns> 实现了 <see cref="IDbResult{T}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IDbResult" />
        /// <seealso cref="IDbResult{T}" />
        /// <seealso cref="DbResult" />
        /// <seealso cref="DbResult{T}" />
        public IDbResult<T> Build<T>(T result) => new DbResult<T>(m_completed, m_exception) { Result = result };

        /// <summary> 重置 <see cref="DbResultBuilder" /> 类型的对象实例。 </summary>
        /// <returns> <see cref="DbResultBuilder" /> 类型的对象实例。 </returns>
        public DbResultBuilder Reset()
        {
            m_completed = true;
            m_exception = null;

            return this;
        }

        /// <summary> 设置数据库事务是否执行成功。 </summary>
        /// <param name="value"> 是否执行成功。 </param>
        /// <returns> <see cref="DbResultBuilder" /> 类型的对象实例。 </returns>
        public DbResultBuilder WithCompleted(bool value = true)
        {
            m_completed = value;
            return this;
        }

        /// <summary> 设置数据库事务执行过程中的异常。 </summary>
        /// <param name="exception"> 派生自 <see cref="Exception" /> 类型的对象实例。 </param>
        /// <returns> <see cref="DbResultBuilder" /> 类型的对象实例。 </returns>
        /// <seealso cref="Exception" />
        public DbResultBuilder WithExecutionException(Exception exception = null)
        {
            m_exception = exception;
            return this;
        }
    }
}