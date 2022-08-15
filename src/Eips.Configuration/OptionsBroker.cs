/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Microsoft.Extensions.Options;
using Niacomsoft.Eips.Options;

namespace Niacomsoft.Eips.Configuration
{
    /// <summary>
    /// 提供了访问配置选项信息相关的方法。
    /// <para> 仅适用于 .NET Standard、.NET Core、.NET vNext 。 </para>
    /// </summary>
    /// <typeparam name="TOptions">
    /// 实现了 <see cref="IConfigurableOptions" /> 接口的类型。
    /// </typeparam>
    /// <seealso cref="IOptionsBroker{TOptions}" />
    /// <seealso cref="IConfigurableOptions" />
    /// <seealso cref="ConfigurationBroker{TOptions}" />
    public class OptionsBroker<TOptions> : ConfigurationBroker<TOptions>, IOptionsBroker<TOptions>
        where TOptions : class, IConfigurableOptions
    {
        /// <summary> 用于初始化一个 <see cref="OptionsBroker{TOptions}" /> 类型的对象实例。 </summary>
        /// <param name="options"> 实现了 <see cref="IOptions{TOptions}" /> 类型接口的对象实例。 </param>
        public OptionsBroker(IOptions<TOptions> options)
        {
            Options = options;
        }

        /// <summary> 配置选项信息。 </summary>
        /// <value> 获取 <see cref="IOptions{TOptions}" /> 类型的对象实例，用于表示配置选项信息。 </value>
        /// <seealso cref="IOptions{TOptions}" />
        public IOptions<TOptions> Options { get; }

        /// <summary> 获取配置选项。 </summary>
        /// <returns> 实现了 <see cref="IConfigurableOptions" /> 类型接口的对象实例。 </returns>
        public override TOptions GetOptions() => Options.Value;
    }
}