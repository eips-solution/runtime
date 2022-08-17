/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;
using System.Data;

namespace Niacomsoft.Eips.Data
{
    /// <summary>
    /// 提供了数据库连接变更事件相关的参数。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="EventArgs" />
    public sealed class ConnectionStateChangedEventArgs : EventArgs
    {
        /// <summary>
        /// 用于初始化一个 <see cref="ConnectionStateChangedEventArgs" /> 类型的对象实例。
        /// </summary>
        /// <param name="state">
        /// 数据库连接状态值。
        /// <para> <see cref="ConnectionState" /> 类型的值。 </para>
        /// </param>
        public ConnectionStateChangedEventArgs(ConnectionState state) => CurrentState = state;

        /// <summary> 当前的连接状态。 </summary>
        /// <value> 获取一个值，用于表示当前的连接状态。 </value>
        /// <seealso cref="ConnectionState" />
        public ConnectionState CurrentState { get; }
    }
}