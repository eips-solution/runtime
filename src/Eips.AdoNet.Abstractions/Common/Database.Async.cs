/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Data;
using System.Threading.Tasks;

namespace Niacomsoft.Eips.Data.Common
{
#if !NET40
    public abstract partial class Database : IDbConnectionAsyncInterface, IDbTransactionAsyncInterface
    {
        /// <summary> (异步的方法) 启用一个数据库事务。 </summary>
        /// <param name="isolation">
        /// 事务隔离级别。
        /// <para> 可为空的 <see cref="IsolationLevel" /> 类型的值。 </para>
        /// </param>
        /// <returns>
        /// 数据库事务对象实例。
        /// <para> 实现了 <see cref="IDbTransaction" /> 类型接口的对象实例。 </para>
        /// </returns>
        /// <seealso cref="IsolationLevel" />
        /// <seealso cref="IDbTransaction" />
        /// <seealso cref="Task{TResult}" />
        public Task<IDbTransaction> BeginTransactionAsync(IsolationLevel? isolation = null) => Task.Run(() => BeginTransaction(isolation));

        /// <summary> (异步的方法) 关闭数据库连接。 </summary>
        /// <returns> <see cref="Task" /> 类型的对象实例。 </returns>
        /// <seealso cref="Task" />
        public virtual Task CloseAsync() => Task.Run(() => InternalClose());

        /// <summary> (异步的方法) 提交一个数据库事务。 </summary>
        /// <param name="transaction"> 实现了 <see cref="IDbTransaction" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IDbTransaction" />
        /// <seealso cref="Task" />
        public Task CommitAsync(IDbTransaction transaction) => Task.Run(() => Commit(transaction));

        /// <summary> (异步的方法) 打开数据库连接。 </summary>
        /// <returns> <see cref="Task" /> 类型的对象实例。 </returns>
        /// <seealso cref="Task" />
        public virtual Task OpenAsync() => Task.Run(() => InternalOpen());

        /// <summary> (异步的方法) 回滚一个数据库事务。 </summary>
        /// <param name="transaction"> 实现了 <see cref="IDbTransaction" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IDbTransaction" />
        /// <seealso cref="Task" />
        public Task RollbackAsync(IDbTransaction transaction) => Task.Run(() => Rollback(transaction));
    }
#endif
}