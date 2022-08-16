/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Niacomsoft.Eips.Configuration;
using Niacomsoft.Eips.Extensions;
using Niacomsoft.Eips.Extensions.Runtime.Serializations;
using Niacomsoft.Eips.Options;
using Niacomsoft.Eips.Reflection;
using Niacomsoft.Eips.Runtime.Serializations;
using Niacomsoft.Eips.Security;
using Niacomsoft.Eips.Security.Cryptography;

namespace Niacomsoft.Eips.DependencyInjection
{
    /// <summary> 为 <see cref="IServiceCollection" /> 类型提供的扩展方法。 </summary>
    public static class RuntimeServicesCollectionExtensions
    {
        /// <summary> 注册单例模式的运行时服务。 </summary>
        /// <param name="services">
        /// 实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。
        /// </param>
        private static void AddSingletonRuntimeServicesImpl(IServiceCollection services)
        {
            services.AddSingleton<IFluentInterface, FluentInterface>()
                    .AddSingleton<RandomPasswordGenerator>()
                    .AddSingleton<GuidGenerator>()
                    .AddSingleton<NanoidGenerator>();
        }

        /// <summary> 注册短暂模式的运行时模式。 </summary>
        /// <param name="services">
        /// 实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。
        /// </param>
        private static void AddTransientRuntimeServicesImpl(IServiceCollection services)
        {
            services.AddTransient<MemberAttributeHelper>()
                    .AddTransient<AssemblyAttributeHelper>()
                    .AddTransient<EnvironmentVariableAccessor>()
                    .AddTransient<XmlSerializer>()
                    .AddTransient<JsonSerializer>()
                    .AddTransient<MD5AlgorithmsProvider>()
                    .AddTransient<SHA1AlgorithmsProvider>()
                    .AddTransient<SHA256AlgorithmsProvider>()
                    .AddTransient<SHA384AlgorithmsProvider>()
                    .AddTransient<SHA512AlgorithmsProvider>()
                    .AddTransient<HashAlgorithmsFactory>()
                    .AddTransient<ISymmetricCryptographicKey, DESCryptographicKey>()
                    .AddTransient<DESAlgorithmsProvider>()
                    .AddTransient<IAESCryptographicKey, AESCryptographicKey>()
                    .AddTransient<AES128AlgorithmsProvider>()
                    .AddTransient<AES192AlgorithmsProvider>()
                    .AddTransient<AES256AlgorithmsProvider>()
                    .AddTransient<AESAlgorithmsProvider>()
                    .AddTransient<IHashIdCryptographyKeyProvider, HashIdCryptographyKeyProvider>()
                    .AddTransient<Int32HashFormatter>()
                    .AddTransient<Int64HashFormatter>()
                    .AddTransient<IObservableOptionsBroker<NanoIdOptions>, ObservableOptionsBroker<NanoIdOptions>>();
        }

        /// <summary> 配置运行时服务。 </summary>
        /// <param name="services">
        /// 实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。
        /// </param>
        /// <seealso cref="IServiceCollection" />
        private static void ConfigureRuntimeConfigurationOptions(IServiceCollection services)
        {
            services.AddOptions<EipsOptions>()
                    .Configure<IConfiguration>((opt, config) => config.Bind(EipsOptions.Key, opt));
            services.AddOptions<UtilitiesOptions>()
                    .Configure<IConfiguration>((opt, config) => config.Bind($"{EipsOptions.Key}:{UtilitiesOptions.Key}", opt));
            services.AddOptions<NanoIdOptions>()
                    .Configure<IConfiguration>((opt, config) => config.Bind($"{EipsOptions.Key}:{UtilitiesOptions.Key}:{NanoIdOptions.Key}", opt));
        }

        /// <summary> 注册 EIPS 运行时相关服务。 </summary>
        /// <param name="services">
        /// 实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。
        /// </param>
        /// <returns> 实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IServiceCollection" />
        public static IServiceCollection AddEipsRuntimeServices(this IServiceCollection services)
        {
            AddSingletonRuntimeServicesImpl(services);
            AddTransientRuntimeServicesImpl(services);
            ConfigureRuntimeConfigurationOptions(services);

            return services;
        }
    }
}