/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;
using System.Collections.Generic;
using System.Data;

namespace Niacomsoft.Eips.Data
{
    /// <summary> 定义了数据库访问的接口。 </summary>
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
    public interface IDatabase<TDbConnection, TDbTransaction, TDbCommand, TDataParameter, TDataReader>
        where TDbTransaction : IDbTransaction
        where TDbCommand : IDbCommand
        where TDataParameter : IDataParameter
        where TDataReader : IDataReader
    {
        /// <summary> 数据库连接状态变更事件。 </summary>
        /// <seealso cref="EventHandler{TEventArgs}" />
        /// <seealso cref="ConnectionState" />
        /// <seealso cref="ConnectionStateChangedEventArgs" />
        event EventHandler<ConnectionStateChangedEventArgs> ConnectionStateChanged;

        /// <summary> 数据库连接。 </summary>
        /// <value> 获取 <typeparamref name="TDbConnection" /> 类型的对象实例，用于表示数据库连接。 </value>
        /// <seealso cref="IDbConnection" />
        TDbConnection Connection { get; }

        /// <summary> 数据库连接串。 </summary>
        /// <value> 获取一个字符串，用于表示数据库连接串。 </value>
        string ConnectionString { get; }

        /// <summary> 数据库访问程序名称。 </summary>
        /// <value> 获取一个字符串，用于表示数据库访问程序名称。 </value>
        string ProviderName { get; }

        /// <summary> 数据库连接超时设置（单位：秒）。 </summary>
        /// <value> 获取一个值，用于表示数据库连接超时设置（单位：秒）。 </value>
        int Timeout { get; }

        /// <summary> 向 <paramref name="cmd" /> 添加参数 <paramref name="parameter" />。 </summary>
        /// <param name="cmd">
        /// 数据库命令。
        /// <para> <typeparamref name="TDbCommand" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="parameter">
        /// 数据库命令参数。
        /// <para> <typeparamref name="TDataParameter" /> 类型的对象实例。 </para>
        /// </param>
        /// <seealso cref="IDbCommand" />
        /// <seealso cref="IDataParameter" />
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="cmd" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        void AddParameter(TDbCommand cmd, TDataParameter parameter);

        /// <summary>
        /// 向 <paramref name="cmd" /> 添加参数 <paramref name="parameters" /> 集合。
        /// </summary>
        /// <param name="cmd">
        /// 数据库命令。
        /// <para> <typeparamref name="TDbCommand" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="parameters">
        /// 数据库命令参数集合。
        /// <para> <typeparamref name="TDataParameter" /> 类型的对象实例集合。 </para>
        /// </param>
        /// <seealso cref="IDbCommand" />
        /// <seealso cref="IDataParameter" />
        /// <seealso cref="IEnumerable{T}" />
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="cmd" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        void AddParameters(TDbCommand cmd, IEnumerable<TDataParameter> parameters);

        /// <summary> 启用一个数据库事务。 </summary>
        /// <param name="isolation"> 可为空的 <see cref="IsolationLevel" /> 类型的值。 </param>
        /// <returns> <typeparamref name="TDbTransaction" /> 类型的对象实例。 </returns>
        /// <seealso cref="IsolationLevel" />
        /// <seealso cref="IDbTransaction" />
        TDbTransaction BeginTransaction(IsolationLevel? isolation = null);

        /// <summary> 关闭 <typeparamref name="TDbConnection" /> 类型的数据库连接。 </summary>
        void Close();

        /// <summary> 提交数据库事务。 </summary>
        /// <param name="transaction">
        /// 数据库事务。
        /// <para> <typeparamref name="TDbTransaction" /> 类型的对象实例。 </para>
        /// </param>
        /// <seealso cref="IDbTransaction" />
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="transaction" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        void Commit(TDbTransaction transaction);

        /// <summary> 创建数据库命令。 </summary>
        /// <param name="cmdText"> 数据库命令文本。 </param>
        /// <param name="cmdType">
        /// 数据库命令类型。
        /// <para> <see cref="CommandType" /> 类型的值。 </para>
        /// </param>
        /// <param name="cmdTimeout"> 数据库命令执行超时（单位：秒）。 </param>
        /// <param name="parameters">
        /// 数据库命令参数数组。
        /// <para> <typeparamref name="TDataParameter" /> 类型的对象实例数组。 </para>
        /// </param>
        /// <returns>
        /// 数据库命令。
        /// <para> <typeparamref name="TDbCommand" /> 类型的对象实例。 </para>
        /// </returns>
        /// <seealso cref="CommandType" />
        /// <seealso cref="IDataParameter" />
        TDbCommand CreateCommand(string cmdText,
                                 CommandType cmdType = CommandType.Text,
                                 int cmdTimeout = 0,
                                 params TDataParameter[] parameters);

        /// <summary> 创建 <see cref="CommandType.Text" /> 类型数据库命令。 </summary>
        /// <param name="cmdText"> 数据库命令文本。 </param>
        /// <param name="cmdTimeout"> 数据库命令执行超时（单位：秒）。 </param>
        /// <param name="parameters">
        /// 数据库命令参数数组。
        /// <para> <typeparamref name="TDataParameter" /> 类型的对象实例数组。 </para>
        /// </param>
        /// <returns>
        /// 数据库命令。
        /// <para> <typeparamref name="TDbCommand" /> 类型的对象实例。 </para>
        /// </returns>
        /// <seealso cref="CommandType.Text" />
        /// <seealso cref="IDataParameter" />
        TDbCommand CreateCommandText(string cmdText,
                                 int cmdTimeout = 0,
                                 params TDataParameter[] parameters);

        /// <summary> 创建用于输入的数据库参数。 </summary>
        /// <param name="name"> 参数名称。 </param>
        /// <param name="value"> 参数值。 </param>
        /// <param name="dbType">
        /// 参数类型。
        /// <para> 可为空的 <see cref="DbType" /> 类型的值。 </para>
        /// </param>
        /// <param name="size">
        /// 参数大小。
        /// <para> 可为空的 <see cref="int" /> 类型的值。 </para>
        /// </param>
        /// <returns>
        /// 数据库参数。
        /// <para> <typeparamref name="TDataParameter" /> 类型的对象实例。 </para>
        /// </returns>
        /// <seealso cref="IDataParameter" />
        /// <seealso cref="ParameterDirection.Input" />
        /// <seealso cref="DbType" />
        TDataParameter CreateInParameter(string name,
                                     object value = null,
                                     DbType? dbType = null,
                                     int? size = null);

        /// <summary> 创建用于输出的数据库参数。 </summary>
        /// <param name="name"> 参数名称。 </param>
        /// <param name="value"> 参数值。 </param>
        /// <param name="dbType">
        /// 参数类型。
        /// <para> 可为空的 <see cref="DbType" /> 类型的值。 </para>
        /// </param>
        /// <param name="size">
        /// 参数大小。
        /// <para> 可为空的 <see cref="int" /> 类型的值。 </para>
        /// </param>
        /// <returns>
        /// 数据库参数。
        /// <para> <typeparamref name="TDataParameter" /> 类型的对象实例。 </para>
        /// </returns>
        /// <seealso cref="IDataParameter" />
        /// <seealso cref="ParameterDirection.Output" />
        /// <seealso cref="DbType" />
        TDataParameter CreateOutParameter(string name,
                                     object value = null,
                                     DbType? dbType = null,
                                     int? size = null);

        /// <summary> 创建数据库参数。 </summary>
        /// <param name="name"> 参数名称。 </param>
        /// <param name="value"> 参数值。 </param>
        /// <param name="direction"> <see cref="ParameterDirection" /> 类型的值。 </param>
        /// <param name="dbType">
        /// 参数类型。
        /// <para> 可为空的 <see cref="DbType" /> 类型的值。 </para>
        /// </param>
        /// <param name="size">
        /// 参数大小。
        /// <para> 可为空的 <see cref="int" /> 类型的值。 </para>
        /// </param>
        /// <returns>
        /// 数据库参数。
        /// <para> <typeparamref name="TDataParameter" /> 类型的对象实例。 </para>
        /// </returns>
        /// <seealso cref="IDataParameter" />
        /// <seealso cref="ParameterDirection" />
        /// <seealso cref="DbType" />
        TDataParameter CreateParameter(string name,
                                     object value = null,
                                     ParameterDirection direction = ParameterDirection.Input,
                                     DbType? dbType = null,
                                     int? size = null);

        /// <summary> 创建数据库存储过程命令。 </summary>
        /// <param name="storedProcedureName"> 存储过程名称。 </param>
        /// <param name="cmdTimeout"> 数据库命令执行超时（单位：秒）。 </param>
        /// <param name="parameters">
        /// 数据库命令参数数组。
        /// <para> <typeparamref name="TDataParameter" /> 类型的对象实例数组。 </para>
        /// </param>
        /// <returns>
        /// 数据库命令。
        /// <para> <typeparamref name="TDbCommand" /> 类型的对象实例。 </para>
        /// </returns>
        /// <seealso cref="CommandType.StoredProcedure" />
        /// <seealso cref="IDataParameter" />
        TDbCommand CreateStoredProcedure(string storedProcedureName,
                                 int cmdTimeout = 0,
                                 params TDataParameter[] parameters);

        /// <summary> 执行数据库查询命令，并返回数据集。 </summary>
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
        DataSet ExecuteDataSet(TDbCommand selectCmd, string dateSetName = null);

        /// <summary> 执行数据库查询，并返回数据集。 </summary>
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
        DataSet ExecuteDataSet(string selectCmdText,
                               CommandType selectCmdType = CommandType.Text,
                               int selectTimeout = 0,
                               string dateSetName = null,
                               params TDataParameter[] parameters);

        /// <summary> 执行数据库更新命令，并返回影响行数。 </summary>
        /// <param name="updateCmd">
        /// 数据库更新命令。
        /// <para> <typeparamref name="TDbCommand" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> 影响行数。 </returns>
        /// <seealso cref="IDbCommand" />
        int ExecuteNonQuery(TDbCommand updateCmd);

        /// <summary> 执行数据库更新命令，并返回影响行数。 </summary>
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
        int ExecuteNonQuery(string updateCmdText,
                            CommandType updateCmdType = CommandType.Text,
                            int updateTimeout = 0,
                            params TDataParameter[] parameters);

        /// <summary> 执行数据库命令，并返回数据读取器。 </summary>
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
        TDataReader ExecuteReader(TDbCommand cmd, CommandBehavior? behavior = null);

        /// <summary> 执行数据库命令，并返回数据读取器。 </summary>
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
        TDataReader ExecuteReader(string cmdText,
                                  CommandType cmdType = CommandType.Text,
                                  CommandBehavior? behavior = null,
                                  int cmdTimeout = 0,
                                  params TDataParameter[] parameters);

        /// <summary> 执行数据库命令，并返回标量值。 </summary>
        /// <param name="cmd">
        /// 数据库命令。
        /// <para> <typeparamref name="TDbCommand" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> 标量值。 </returns>
        /// <seealso cref="IDbCommand" />
        object ExecuteScalar(TDbCommand cmd);

        /// <summary> 执行数据库命令，并返回标量值。 </summary>
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
        object ExecuteScalar(string cmdText,
                             CommandType cmdType = CommandType.Text,
                             int cmdTimeout = 0,
                             params TDataParameter[] parameters);

        /// <summary> 打开 <typeparamref name="TDbConnection" /> 类型的数据库连接。 </summary>
        void Open();

        /// <summary> 回滚数据库事务。 </summary>
        /// <param name="transaction">
        /// 数据库事务。
        /// <para> <typeparamref name="TDbTransaction" /> 类型的对象实例。 </para>
        /// </param>
        /// <seealso cref="IDbTransaction" />
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="transaction" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        void Rollback(TDbTransaction transaction);
    }
}