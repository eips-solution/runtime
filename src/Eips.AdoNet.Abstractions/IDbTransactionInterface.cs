/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Data;

namespace Niacomsoft.Eips.Data
{
    /// <summary> 定义了数据库事务相关的接口。 </summary>
    public interface IDbTransactionInterface
    {
        /// <summary> 启用一个数据库事务。 </summary>
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
        IDbTransaction BeginTransaction(IsolationLevel? isolation = null);

        /// <summary> 提交一个数据库事务。 </summary>
        /// <param name="transaction"> 实现了 <see cref="IDbTransaction" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IDbTransaction" />
        void Commit(IDbTransaction transaction);

        /// <summary> 回滚一个数据库事务。 </summary>
        /// <param name="transaction"> 实现了 <see cref="IDbTransaction" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IDbTransaction" />
        void Rollback(IDbTransaction transaction);
    }
}