/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Options
{
    /// <summary>
    /// 提供了 EIPS 平台相关的配置选项。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IConfigurableOptions" />
    public sealed class EipsOptions : IConfigurableOptions
    {
        /// <summary> 配置选项标识路径。 </summary>
        public const string Key = "eips";

        /// <summary> 连接串配置。 </summary>
        /// <value> 设置或获取 <see cref="ConnectionStringOptions" /> 类型的对象实例数组，用于表示连接串配置。 </value>
        /// <seealso cref="ConnectionStringOptions" />
        public ConnectionStringOptions[] ConnectionStrings { get; set; }

        /// <summary> 默认的连接名称。 </summary>
        /// <value> 设置或获取一个字符串，用于表示默认的连接名称。 </value>
        public string DefaultConnection { get; set; }

        /// <summary> 企业私有化 SaaS 服务 - 工具配置。 </summary>
        /// <value> 设置或获取 ? 类型的对象实例，用于表示企业私有化 SaaS 服务 - 工具配置。 </value>
        /// <seealso cref="UtilitiesOptions" />
        public UtilitiesOptions Utilities { get; set; }
    }
}