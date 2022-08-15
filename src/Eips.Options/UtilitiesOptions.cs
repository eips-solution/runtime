/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Options
{
    /// <summary>
    /// 提供了工具相关的配置选项。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IConfigurableOptions" />
    public sealed class UtilitiesOptions : IConfigurableOptions
    {
        /// <summary> 配置选项标识。 </summary>
        public const string Key = "eips:utilities";

        /// <summary> 生成 NanoId 所需的配置选项。 </summary>
        /// <value>
        /// 设置或获取 <see cref="NanoIdOptions" /> 类型的对象实例，用于表示生成 NanoId 所需的配置选项。
        /// </value>
        /// <seealso cref="NanoIdOptions" />
        public NanoIdOptions Nanoid { get; set; }
    }
}