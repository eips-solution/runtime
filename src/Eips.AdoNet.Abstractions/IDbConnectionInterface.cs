/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;
using System.Data;

namespace Niacomsoft.Eips.Data
{
    /// <summary> 定义了管理数据库连接的接口。 </summary>
    public interface IDbConnectionInterface
    {
        /// <summary> 数据库连接状态变更事件。 </summary>
        /// <seealso cref="ConnectionStateChangedEventArgs" />
        /// <seealso cref="EventHandler{TEventArgs}" />
        event EventHandler<ConnectionStateChangedEventArgs> ConnectionStateChanged;

        /// <summary> 数据库连接。 </summary>
        /// <value> 获取 <see cref="IDbConnection" /> 类型的对象实例，用于表示数据库连接。 </value>
        /// <seealso cref="IDbConnection" />
        IDbConnection Connection { get; }

        /// <summary> 数据库连接串。 </summary>
        /// <value> 获取一个字符串，用于表示数据库连接串。 </value>
        string ConnectionString { get; }

        /// <summary> 数据库连接超时时间（单位：秒）。 </summary>
        /// <value> 获取一个值，用于表示数据库连接超时时间（单位：秒）。 </value>
        int Timeout { get; }

        /// <summary> 关闭数据库连接。 </summary>
        void Close();

        /// <summary> 打开数据库连接。 </summary>
        void Open();
    }
}