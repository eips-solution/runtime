/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Microsoft.Extensions.Options;
using Niacomsoft.Eips.Options;

namespace Niacomsoft.Eips.Configuration
{
    /// <summary> 定义了访问配置选项信息的接口。 </summary>
    /// <typeparam name="TOptions">
    /// 实现了 <see cref="IConfigurableOptions" /> 接口的类型。
    /// </typeparam>
    /// <seealso cref="IConfigurationBroker{TOptions}" />
    /// <seealso cref="IConfigurableOptions" />
    public interface IOptionsBroker<TOptions> : IConfigurationBroker<TOptions>
        where TOptions : class, IConfigurableOptions
    {
        /// <summary> 配置选项信息。 </summary>
        /// <value> 获取 <see cref="IOptions{TOptions}" /> 类型的对象实例，用于表示配置选项信息。 </value>
        /// <seealso cref="IOptions{TOptions}" />
        IOptions<TOptions> Options { get; }
    }
}