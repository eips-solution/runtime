/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Options;

namespace Niacomsoft.Eips.Configuration
{
    /// <summary> 提供了访问配置信息相关的基本方法。 </summary>
    /// <typeparam name="TOptions">
    /// 实现了 <see cref="IConfigurableOptions" /> 接口的类型。
    /// </typeparam>
    /// <seealso cref="IConfigurableOptions" />
    /// <seealso cref="IConfigurationBroker{TOptions}" />
    public abstract class ConfigurationBroker<TOptions> : IConfigurationBroker<TOptions>
        where TOptions : IConfigurableOptions
    {
        /// <summary> 获取配置选项。 </summary>
        /// <returns> 实现了 <see cref="IConfigurableOptions" /> 类型接口的对象实例。 </returns>
        public abstract TOptions GetOptions();
    }
}