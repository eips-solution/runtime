/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Options
{
    /// <summary>
    /// 提供了连接串配置选项相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    public sealed class ConnectionStringOptions
    {
        private int? m_timeout;

        /// <summary> 连接串。 </summary>
        /// <value> 设置或获取一个字符串，用于表示连接串。 </value>
        public string ConnectionString { get; set; }

        /// <summary> 连接串描述信息。 </summary>
        /// <value> 设置或获取一个字符串，用于表示连接串描述信息。 </value>
        public string Description { get; set; }

        /// <summary> 连接串名称。 </summary>
        /// <value> 设置或获取一个字符串，用于表示连接串名称。 </value>
        public string Name { get; set; }

        /// <summary> 连接程序名称。 </summary>
        /// <value> 设置或获取一个字符串，用于表示连接程序名称。 </value>
        public string ProviderName { get; set; }

        /// <summary> 只读的连接串。 </summary>
        /// <value> 设置或获取一个字符串数组，用于表示只读的连接串。 </value>
        public string[] ReadonlyConnectionStrings { get; set; }

        /// <summary> 连接超时（单位：秒）。 </summary>
        /// <value> 设置或获取一个值，用于表示连接超时（单位：秒）。 </value>
        public int? Timeout
        {
            get { return ParameterGuard.SafeGet(m_timeout, 30); }
            set { m_timeout = value; }
        }
    }
}