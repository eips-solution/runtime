/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Microsoft.Extensions.DependencyInjection;
using System;

namespace Niacomsoft.Eips.DependencyInjection
{
    /// <summary> 提供了 .NET 组合式 API 相关的方法。 </summary>
    /// <seealso cref="IFluentInterface" />
    public class FluentInterface : IFluentInterface
    {
        /// <summary> 用于初始化一个 <see cref="FluentInterface" /> 类型的对象实例。 </summary>
        /// <param name="service"> .NET vNext 依赖注入服务。 </param>
        /// <param name="services"> .NET vNext 依赖注入服务集合。 </param>
        public FluentInterface(IServiceProvider service, IServiceCollection services)
        {
            Service = service;
            Services = services;
        }

        /// <summary> .NET vNext 依赖注入服务。 </summary>
        /// <value>
        /// 获取 <see cref="IServiceProvider" /> 类型的对象实例，用于表示 .NET vNext 依赖注入服务。
        /// </value>
        /// <seealso cref="IServiceProvider" />
        public virtual IServiceProvider Service { get; }

        /// <summary> .NET vNext 依赖注入服务集合。 </summary>
        /// <value>
        /// 获取 <see cref="IServiceCollection" /> 类型的对象实例，用于表示 .NET vNext 依赖注入服务集合。
        /// </value>
        /// <seealso cref="IServiceCollection" />
        public virtual IServiceCollection Services { get; }
    }
}