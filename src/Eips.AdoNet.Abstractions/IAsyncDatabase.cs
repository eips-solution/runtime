/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;
using System.Data;
using System.Threading.Tasks;

namespace Niacomsoft.Eips.Data
{
    /// <summary> 定义了异步的数据库访问的接口。 </summary>
    /// <typeparam name="TDbConnection">
    /// 实现了 <see cref="IDbConnection" /> 接口的类型。
    /// </typeparam>
    /// <typeparam name="TDbTransaction">
    /// 实现了 <see cref="IDbTransaction" /> 接口的类型。
    /// </typeparam>
    /// <typeparam name="TDbCommand"> 实现了 <see cref="IDbCommand" /> 接口的类型。 </typeparam>
    /// <typeparam name="TDataParameter">
    /// 实现了 <see cref="IDataParameter" /> 类型接口的对象实例。
    /// </typeparam>
    /// <typeparam name="TDataReader">
    /// 实现了 <see cref="IDataReader" /> 接口的类型。
    /// </typeparam>
    /// <seealso cref="IDatabase{TDbConnection, TDbTransaction, TDbCommand, TDataParameter, TDataReader}" />
    public interface IAsyncDatabase<TDbConnection, TDbTransaction, TDbCommand, TDataParameter, TDataReader>
        : IDatabase<TDbConnection, TDbTransaction, TDbCommand, TDataParameter, TDataReader>
        where TDbTransaction : IDbTransaction
        where TDbCommand : IDbCommand
        where TDataParameter : IDataParameter
        where TDataReader : IDataReader
    {
        /// <summary> (异步的方法) 启用一个数据库事务。 </summary>
        /// <param name="isolation"> 可为空的 <see cref="IsolationLevel" /> 类型的值。 </param>
        /// <returns> <typeparamref name="TDbTransaction" /> 类型的对象实例。 </returns>
        /// <seealso cref="IsolationLevel" />
        /// <seealso cref="IDbTransaction" />
        /// <seealso cref="Task{TResult}" />
        Task<TDbTransaction> BeginTransactionAsync(IsolationLevel? isolation = null);

        /// <summary>
        /// (异步的方法) 关闭 <typeparamref name="TDbConnection" /> 类型的数据库连接。
        /// </summary>
        /// <returns> <see cref="Task" /> 类型的对象实例。 </returns>
        /// <seealso cref="Task" />
        Task CloseAsync();

        /// <summary> (异步的方法) 提交数据库事务。 </summary>
        /// <param name="transaction">
        /// 数据库事务。
        /// <para> <typeparamref name="TDbTransaction" /> 类型的对象实例。 </para>
        /// </param>
        /// <seealso cref="IDbTransaction" />
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="transaction" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        /// <returns> <see cref="Task" /> 类型的对象实例。 </returns>
        /// <seealso cref="Task" />
        Task CommitAsync(TDbTransaction transaction);

        /// <summary> (异步的方法) 执行数据库查询，并返回数据集。 </summary>
        /// <param name="selectCmdText"> 数据库查询命令文本。 </param>
        /// <param name="selectCmdType">
        /// 数据库查询命令类型。
        /// <para> <see cref="CommandType" /> 类型的值。 </para>
        /// </param>
        /// <param name="selectTimeout"> 查询命令执行超时（单位：秒）。 </param>
        /// <param name="dateSetName"> 数据集名称。 </param>
        /// <param name="parameters"> 数据库查询命令参数数组。 </param>
        /// <returns>
        /// 数据集。
        /// <para> <see cref="DataSet" /> 类型的对象实例。 </para>
        /// </returns>
        /// <seealso cref="IDataParameter" />
        /// <seealso cref="CommandType" />
        /// <seealso cref="DataSet" />
        /// <seealso cref="Task{TResult}" />
        Task<DataSet> ExecuteDataSetAsync(string selectCmdText,
                               CommandType selectCmdType = CommandType.Text,
                               int selectTimeout = 0,
                               string dateSetName = null,
                               params TDataParameter[] parameters);

        /// <summary> (异步的方法) 执行数据库查询命令，并返回数据集。 </summary>
        /// <param name="selectCmd">
        /// 数据库查询命令。
        /// <para> <typeparamref name="TDbCommand" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="dateSetName"> 数据集名称。 </param>
        /// <returns>
        /// 数据集。
        /// <para> <see cref="DataSet" /> 类型的对象实例。 </para>
        /// </returns>
        /// <seealso cref="IDbCommand" />
        /// <seealso cref="DataSet" />
        /// <seealso cref="Task{TResult}" />
        Task<DataSet> ExecuteDataSetAsync(TDbCommand selectCmd, string dateSetName = null);

        /// <summary> (异步的方法) 执行数据库更新命令，并返回影响行数。 </summary>
        /// <param name="updateCmd">
        /// 数据库更新命令。
        /// <para> <typeparamref name="TDbCommand" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> 影响行数。 </returns>
        /// <seealso cref="IDbCommand" />
        /// <seealso cref="Task{TResult}" />
        Task<int> ExecuteNonQueryAsync(TDbCommand updateCmd);

        /// <summary> (异步的方法) 执行数据库更新命令，并返回影响行数。 </summary>
        /// <param name="updateCmdText"> 数据库更新命令。 </param>
        /// <param name="updateCmdType">
        /// 数据库更新命令类型。
        /// <para> <see cref="CommandType" /> 类型的值。 </para>
        /// </param>
        /// <param name="updateTimeout"> 更新命令超时设置（单位：秒）。 </param>
        /// <param name="parameters"> 数据库命令参数数组。 </param>
        /// <returns> 影响行数。 </returns>
        /// <seealso cref="IDataParameter" />
        /// <seealso cref="CommandType" />
        /// <seealso cref="Task{TResult}" />
        Task<int> ExecuteNonQueryAsync(string updateCmdText,
                            CommandType updateCmdType = CommandType.Text,
                            int updateTimeout = 0,
                            params TDataParameter[] parameters);

        /// <summary> (异步的方法) 执行数据库命令，并返回数据读取器。 </summary>
        /// <param name="cmd">
        /// 数据库命令。
        /// <para> <typeparamref name="TDbCommand" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="behavior"> 可为空的 <see cref="CommandBehavior" /> 类型的值。 </param>
        /// <returns>
        /// 数据读取器。
        /// <para> <typeparamref name="TDataReader" /> 类型的对象实例。 </para>
        /// </returns>
        /// <seealso cref="IDbCommand" />
        /// <seealso cref="IDataReader" />
        /// <seealso cref="CommandBehavior" />
        /// <seealso cref="Task{TResult}" />
        Task<TDataReader> ExecuteReaderAsync(TDbCommand cmd, CommandBehavior? behavior = null);

        /// <summary> (异步的方法) 执行数据库命令，并返回数据读取器。 </summary>
        /// <param name="cmdText"> 数据库命令。 </param>
        /// <param name="cmdType">
        /// 数据库命令类型。
        /// <para> <see cref="CommandType" /> 类型的值。 </para>
        /// </param>
        /// <param name="behavior"> 可为空的 <see cref="CommandBehavior" /> 类型的值。 </param>
        /// <param name="cmdTimeout"> 数据库命令执行超时（单位：秒）。 </param>
        /// <param name="parameters"> 数据库命令参数数组。 </param>
        /// <returns>
        /// 数据读取器。
        /// <para> <typeparamref name="TDataReader" /> 类型的对象实例。 </para>
        /// </returns>
        /// <seealso cref="IDbCommand" />
        /// <seealso cref="IDataReader" />
        /// <seealso cref="IDataParameter" />
        /// <seealso cref="CommandBehavior" />
        /// <seealso cref="CommandType" />
        /// <seealso cref="Task{TResult}" />
        Task<TDataReader> ExecuteReaderAsync(string cmdText,
                                  CommandType cmdType = CommandType.Text,
                                  CommandBehavior? behavior = null,
                                  int cmdTimeout = 0,
                                  params TDataParameter[] parameters);

        /// <summary> (异步的方法) 执行数据库命令，并返回标量值。 </summary>
        /// <param name="cmd">
        /// 数据库命令。
        /// <para> <typeparamref name="TDbCommand" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> 标量值。 </returns>
        /// <seealso cref="IDbCommand" />
        /// <seealso cref="Task{TResult}" />
        Task<object> ExecuteScalarAsync(TDbCommand cmd);

        /// <summary> (异步的方法) 执行数据库命令，并返回标量值。 </summary>
        /// <param name="cmdText"> 数据库命令。 </param>
        /// <param name="cmdType">
        /// 数据库命令类型。
        /// <para> <see cref="CommandType" /> 类型的值。 </para>
        /// </param>
        /// <param name="cmdTimeout"> 数据库命令执行超时（单位：秒）。 </param>
        /// <param name="parameters">
        /// 数据库命令参数数组。
        /// <para> <typeparamref name="TDataParameter" /> 类型的对象实例数组。 </para>
        /// </param>
        /// <returns> 标量值。 </returns>
        /// <seealso cref="IDataParameter" />
        /// <seealso cref="CommandType" />
        Task<object> ExecuteScalarAsync(string cmdText,
                             CommandType cmdType = CommandType.Text,
                             int cmdTimeout = 0,
                             params TDataParameter[] parameters);

        /// <summary>
        /// (异步的方法) 打开 <typeparamref name="TDbConnection" /> 类型的数据库连接。
        /// </summary>
        /// <returns> <see cref="Task" /> 类型的对象实例。 </returns>
        /// <seealso cref="Task" />
        Task OpenAsync();

        /// <summary> (异步的方法) 回滚数据库事务。 </summary>
        /// <param name="transaction">
        /// 数据库事务。
        /// <para> <typeparamref name="TDbTransaction" /> 类型的对象实例。 </para>
        /// </param>
        /// <seealso cref="IDbTransaction" />
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="transaction" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        /// <returns> <see cref="Task" /> 类型的对象实例。 </returns>
        /// <seealso cref="Task" />
        Task RollbackAsync(TDbTransaction transaction);
    }
}