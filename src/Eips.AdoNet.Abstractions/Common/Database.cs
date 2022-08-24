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
        }

        /// <summary> 数据库连接状态变更事件。 </summary>
        /// <seealso cref="ConnectionStateChangedEventArgs" />
        /// <seealso cref="EventHandler{TEventArgs}" />
        public abstract event EventHandler<ConnectionStateChangedEventArgs> ConnectionStateChanged;

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

        /// <summary> 关闭数据库连接。 </summary>
        public abstract void Close();

        /// <summary> 执行与释放或重置非托管资源关联的应用程序定义的任务。 </summary>
        public abstract void Dispose();

        /// <summary> 打开数据库连接。 </summary>
        public abstract void Open();
    }
}