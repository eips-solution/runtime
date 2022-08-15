/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Niacomsoft.Eips.Options;
using System;

namespace Niacomsoft.Eips.Configuration
{
    /// <summary> 提供了访问配置选项信息（可观测的）相关的方法。 </summary>
    /// <typeparam name="TOptions">
    /// 实现了 <see cref="IConfigurableOptions" /> 接口的类型。
    /// </typeparam>
    /// <seealso cref="IObservableOptionsBroker{TOptions}" />
    /// <seealso cref="IConfigurableOptions" />
    /// <seealso cref="ConfigurationBroker{TOptions}" />
    public class ObservableOptionsBroker<TOptions> : ConfigurationBroker<TOptions>, IObservableOptionsBroker<TOptions>
        where TOptions : class, IConfigurableOptions
    {
        /// <summary> 用于引发 <see cref="Changed" /> 事件。 </summary>
        /// <param name="key"> 变更配置标识名称。 </param>
        /// <param name="options"> 变更后的配置选项。 </param>
        /// <seealso cref="Changed" />
        protected void OnChanged(string key, TOptions options)
            => Changed?.Invoke(this, new Tuple<string, TOptions>(key, options));

        /// <summary>
        /// 用于初始化一个 <see cref="ObservableOptionsBroker{TOptions}" /> 类型的对象实例。
        /// </summary>
        /// <param name="logger">
        /// 记录配置选项变更的方法。
        /// <para> 实现了 <see cref="ILogger" /> 类型接口的对象实例。 </para>
        /// </param>
        /// <param name="options">
        /// 访问配置选项信息。
        /// <para> 实现了 <see cref="IOptionsMonitor{TOptions}" /> 类型接口的对象实例。 </para>
        /// </param>
        public ObservableOptionsBroker(ILogger logger, IOptionsMonitor<TOptions> options)
        {
            ConfigurationChangedLogger = logger;
            Options = options;
            Options.OnChange((opt, key) =>
            {
                ConfigurationChangedLogger.LogWarning($"“{opt.GetType().FullName}” 类型的配置选项已经变更，配置标识名称为 “{key}”。");
                OnChanged(key, opt);
            });
        }

        /// <summary> 配置选项变更事件。 </summary>
        /// <seealso cref="EventHandler{TEventArgs}" />
        /// <seealso cref="Tuple{T1, T2}" />
        public event EventHandler<Tuple<string, TOptions>> Changed;

        /// <summary> 用于记录配置变更的方法。 </summary>
        /// <value> 获取 <see cref="ILogger" /> 类型的对象实例，用于表示用于记录配置变更的方法。 </value>
        /// <seealso cref="ILogger" />
        public ILogger ConfigurationChangedLogger { get; }

        /// <summary> 可观测的配置选项。 </summary>
        /// <value> 获取 <see cref="IOptionsMonitor{TOptions}" /> 类型的对象实例，用于表示可观测的配置选项。 </value>
        /// <seealso cref="IOptionsMonitor{TOptions}" />
        public IOptionsMonitor<TOptions> Options { get; }

        /// <summary> 获取配置选项。 </summary>
        /// <returns> 实现了 <see cref="IConfigurableOptions" /> 类型接口的对象实例。 </returns>
        public override TOptions GetOptions() => Options.CurrentValue;
    }
}