/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Options;

namespace Niacomsoft.Eips.Configuration
{
    /// <summary> 提供了 ? 相关的方法。 </summary>
    /// <typeparam name="TOptions"> </typeparam>
    public interface IConfigurationBroker<TOptions>
        where TOptions : IConfigurableOptions
    {
        /// <summary> 获取配置选项。 </summary>
        /// <returns> 实现了 <see cref="IConfigurableOptions" /> 类型接口的对象实例。 </returns>
        TOptions GetOptions();
    }
}