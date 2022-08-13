/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Niacomsoft.Eips.Options;

namespace Niacomsoft.Eips.Configuration
{
    /// <summary> 定义了访问配置选项信息（可观测的）的接口。 </summary>
    /// <typeparam name="TOptions">
    /// 实现了 <see cref="IConfigurableOptions" /> 类型接口的对象实例。
    /// </typeparam>
    /// <seealso cref="IConfigurableOptions" />
    public interface IObservableOptionsBroker<TOptions> where TOptions : class, IConfigurableOptions
    {
        /// <summary> 用于记录配置变更的方法。 </summary>
        /// <value> 获取 <see cref="ILogger" /> 类型的对象实例，用于表示用于记录配置变更的方法。 </value>
        /// <seealso cref="ILogger" />
        ILogger ConfigurationChangedLogger { get; }

        /// <summary> 可观测的配置选项。 </summary>
        /// <value> 获取 <see cref="IOptionsMonitor{TOptions}" /> 类型的对象实例，用于表示可观测的配置选项。 </value>
        /// <seealso cref="IOptionsMonitor{TOptions}" />
        IOptionsMonitor<TOptions> Options { get; }
    }
}