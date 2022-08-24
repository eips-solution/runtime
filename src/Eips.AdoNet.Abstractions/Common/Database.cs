/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Diagnostics;
using Niacomsoft.Eips.Globalization;
using System;
using System.Data;
using System.Diagnostics;

namespace Niacomsoft.Eips.Data.Common
{
    /// <summary> 提供了访问数据库相关的基本方法。 </summary>
    /// <seealso cref="IDisposable" />
    /// <seealso cref="IDbConnectionInterface" />
    public abstract class Database : IDbConnectionInterface, IDisposable
    {
        /// <summary> 用于初始化一个 <see cref="Database" /> 类型的对象实例。 </summary>
        /// <param name="connectionString"> 数据库连接串。 </param>
        /// <param name="timeout"> 数据库连接超时时间（单位：秒）。 </param>
        /// <exception cref="ArgumentException">
        /// 当 <paramref name="connectionString" /> 等于 <c> null </c>、 <see cref="string.Empty" /> 或者空格符时，将引发此类型的异常。
        /// </exception>
        protected Database(string connectionString, int timeout)
        {
            if (StringEqualityComparer.Empty(connectionString))
            {
                throw new ArgumentException(SR.Format("ArgumentException_empty_or_whitespace", nameof(connectionString)), nameof(connectionString));
            }

            ConnectionString = connectionString;
            if (ValueTypeComparer.Compare(timeout, symbol: NumberComparisonSymbols.GreaterThanOrEqual))
                Timeout = timeout;
            else
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget(GetType())
                                                             .WithMethod("Constructor")
                                                             .WithMessage($"数据库连接超时时间 “{nameof(timeout)}” 小于 0，将使用 {nameof(Defaults)}.{nameof(Defaults.DefaultDbConnectTimeout)} 替换。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);
                Timeout = Defaults.DefaultDbConnectTimeout;
            }

            IsOpened = false;

            IsDisposed = false;
        }

        /// <summary> 数据库连接状态变更事件。 </summary>
        /// <seealso cref="ConnectionStateChangedEventArgs" />
        /// <seealso cref="EventHandler{TEventArgs}" />
        public virtual event EventHandler<ConnectionStateChangedEventArgs> ConnectionStateChanged;

        /// <summary> 数据库连接。 </summary>
        /// <value> 获取 <see cref="IDbConnection" /> 类型的对象实例，用于表示数据库连接。 </value>
        /// <seealso cref="IDbConnection" />
        public abstract IDbConnection Connection { get; }

        /// <summary> 数据库连接串。 </summary>
        /// <value> 获取一个字符串，用于表示数据库连接串。 </value>
        public virtual string ConnectionString
        {
            get;
        }

        /// <summary> 数据库连接超时时间（单位：秒）。 </summary>
        /// <value> 获取一个值，用于表示数据库连接超时时间（单位：秒）。 </value>
        public virtual int Timeout
        {
            get;
        }

        /// <summary> 数据库访问相关对象是否已经回收。 </summary>
        /// <value> 设置或获取一个值，用于表示数据库访问相关对象是否已经回收。 </value>
        protected virtual bool IsDisposed { get; set; }

        /// <summary> 数据库连接是否已经打开。 </summary>
        /// <value> 设置或获取一个值，用于表示数据库连接是否已经打开。 </value>
        protected virtual bool IsOpened { get; set; }

        /// <summary> 关闭数据库连接。 </summary>
        public virtual void Close() => InternalClose();

        /// <summary> 执行与释放或重置非托管资源关联的应用程序定义的任务。 </summary>
        public void Dispose()
        {
            // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
            Disposing(disposing: true);
        }

        /// <summary> 打开数据库连接。 </summary>
        public virtual void Open() => InternalOpen();

        /// <summary> 执行与释放或重置非托管资源关联的应用程序定义的任务。 </summary>
        /// <param name="disposing"> 是否释放。 </param>
        protected virtual void Disposing(bool disposing)
        {
            if (!IsDisposed)
            {
                if (disposing)
                {
                    InternalClose();
                    if (ReferenceTypeEqualityComparer.NotNone(Connection))
                        Connection.Dispose();
                }

                ResetComponents();

                IsDisposed = true;
            }
        }

        /// <summary> 初始化数据库连接。 </summary>
        protected abstract void InitializeConnection();

        /// <summary> 关闭数据库连接。 </summary>
        protected virtual void InternalClose()
        {
            if (ReferenceTypeEqualityComparer.NotNone(Connection) && IsOpened)
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget(GetType())
                                                             .WithMethod(nameof(Close))
                                                             .WithMessage($"尝试关闭数据库连接 “{ConnectionString}”。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);
                Connection.Close();
                IsOpened = false;
                OnConnectionStateChanged(Connection.State);

                Debug.WriteLine(new TraceInformationBuilder().WithTarget(GetType())
                                             .WithMethod(nameof(Close))
                                             .WithMessage($"数据库连接 “{ConnectionString}” 已经关闭。")
                                             .Build(),
                Defaults.DefaultDiagnosticCategory);
            }
        }

        /// <summary> 打开数据库连接。 </summary>
        protected virtual void InternalOpen()
        {
            InitializeConnection();
            if (!IsOpened)
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget(GetType())
                                                             .WithMethod(nameof(Open))
                                                             .WithMessage($"尝试打开数据库连接 “{ConnectionString}”。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);

                Connection.Open();
                IsOpened = true;
                OnConnectionStateChanged(Connection.State);

                Debug.WriteLine(new TraceInformationBuilder().WithTarget(GetType())
                                             .WithMethod(nameof(Open))
                                             .WithMessage($"数据库连接 “{ConnectionString}” 已经打开。")
                                             .Build(),
                Defaults.DefaultDiagnosticCategory);
            }
        }

        /// <summary> 用于引发 <see cref="ConnectionStateChanged" /> 事件。 </summary>
        /// <param name="state">
        /// 数据库连接状态。
        /// <para> <see cref="ConnectionState" /> 类型的值。 </para>
        /// </param>
        /// <seealso cref="ConnectionStateChanged" />
        /// <seealso cref="ConnectionState" />
        protected virtual void OnConnectionStateChanged(ConnectionState state)
            => ConnectionStateChanged?.Invoke(this, new ConnectionStateChangedEventArgs(state));

        /// <summary> 重置所有的内部数据库组件。 </summary>
        protected abstract void ResetComponents();

        // // TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器 ~Database() { // 不要更改此代码。请将清理代码放入“Dispose(bool
        // disposing)”方法中 Dispose(disposing: false); }
    }
}