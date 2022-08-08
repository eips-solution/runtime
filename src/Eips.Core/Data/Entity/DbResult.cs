/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips.Data.Entity
{
    /// <summary> 提供了数据库事务执行结果相关的方法。 </summary>
    /// <seealso cref="IDbResult" />
    public class DbResult : IDbResult
    {
        /// <summary> 用于初始化一个 <see cref="DbResult" /> 类型的对象实例。 </summary>
        /// <param name="completed"> 数据库事务是否执行成功。 </param>
        /// <param name="exception"> 数据库事务异常。 </param>
        public DbResult(bool completed, Exception exception)
        {
            Completed = ReferenceTypeEqualityComparer.None(exception) && completed;
            if (ReferenceTypeEqualityComparer.NotNone(exception))
            {
                if (exception is DbExecutionException)
                    ExecutionException = exception as DbExecutionException;
                else
                    ExecutionException = new DbExecutionException(exception);
            }
        }

        /// <summary> 用于初始化一个 <see cref="DbResult" /> 类型的对象实例。 </summary>
        /// <param name="completed"> 数据库事务是否执行成功。 </param>
        public DbResult(bool completed) : this(completed, null)
        {
        }

        /// <summary> 用于初始化一个 <see cref="DbResult" /> 类型的对象实例。 </summary>
        /// <param name="exception"> 数据库事务异常。 </param>
        public DbResult(Exception exception) : this(true, exception)
        {
        }

        /// <summary> 用于初始化一个 <see cref="DbResult" /> 类型的对象实例。 </summary>
        public DbResult() : this(true)
        {
        }

        /// <summary> 数据库事务是否执行成功。 </summary>
        /// <value> 设置或获取一个值，用于表示数据库事务是否执行成功。 </value>
        public virtual bool Completed { get; set; }

        /// <summary> 数据库事务执行异常。 </summary>
        /// <value> 设置或获取 <see cref="DbExecutionException" /> 类型的对象实例，用于表示数据库事务执行异常。 </value>
        /// <seealso cref="DbExecutionException" />
        public virtual DbExecutionException ExecutionException { get; set; }
    }

    /// <summary> 提供了包含了数据结果相关的方法。 </summary>
    /// <typeparam name="T"> 数据结果类型。 </typeparam>
    /// <seealso cref="IDbResult{T}" />
    /// <seealso cref="DbResult" />
    public class DbResult<T> : DbResult, IDbResult<T>
    {
        /// <summary> 用于初始化一个 <see cref="DbResult{T}" /> 类型的对象实例。 </summary>
        /// <param name="completed"> 数据库事务是否执行成功。 </param>
        /// <param name="exception"> 数据库事务异常。 </param>
        public DbResult(bool completed, Exception exception) : base(completed, exception)
        {
        }

        /// <summary> 用于初始化一个 <see cref="DbResult{T}" /> 类型的对象实例。 </summary>
        public DbResult()
        {
        }

        /// <summary> 用于初始化一个 <see cref="DbResult{T}" /> 类型的对象实例。 </summary>
        /// <param name="completed"> 数据库事务是否执行成功。 </param>
        public DbResult(bool completed) : base(completed)
        {
        }

        /// <summary> 用于初始化一个 <see cref="DbResult{T}" /> 类型的对象实例。 </summary>
        /// <param name="exception"> 数据库事务异常。 </param>
        public DbResult(Exception exception) : base(exception)
        {
        }

        /// <summary> 数据库结果。 </summary>
        /// <value> 设置或获取 <typeparamref name="T" /> 类型的对象实例或值，用于表示数据库结果。 </value>
        public virtual T Result { get; set; }
    }
}