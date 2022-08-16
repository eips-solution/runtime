/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.DependencyInjection
{
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER || NET5_0_OR_GREATER || NET462_OR_GREATER
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public partial interface IFluentInterface
    {
        /// <summary> .NET vNext 依赖注入服务。 </summary>
        /// <value>
        /// 获取 <see cref="IServiceProvider" /> 类型的对象实例，用于表示 .NET vNext 依赖注入服务。
        /// </value>
        /// <seealso cref="IServiceProvider" />
        IServiceProvider Service { get; }

        /// <summary> .NET vNext 依赖注入服务集合。 </summary>
        /// <value>
        /// 获取 <see cref="IServiceCollection" /> 类型的对象实例，用于表示 .NET vNext 依赖注入服务集合。
        /// </value>
        /// <seealso cref="IServiceCollection" />
        IServiceCollection Services { get; }
    }
#endif
}