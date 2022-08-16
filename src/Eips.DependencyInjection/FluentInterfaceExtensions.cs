/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Microsoft.Extensions.DependencyInjection;
using Niacomsoft.Eips.Extensions;
using Niacomsoft.Eips.Extensions.Runtime.Serializations;
using Niacomsoft.Eips.Reflection;
using Niacomsoft.Eips.Runtime.Serializations;
using Niacomsoft.Eips.Runtime.Serializations.Json;
using Niacomsoft.Eips.Security;
using Niacomsoft.Eips.Security.Cryptography;
using System;
using System.Reflection;

namespace Niacomsoft.Eips.DependencyInjection
{
    /// <summary> 为 <see cref="IFluentInterface" /> 类型提供的扩展方法。 </summary>
    public static class FluentInterfaceExtensions
    {
        /// <summary> 使用 AES 对称加密算法。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <param name="keySize">
        /// AES 算法密钥长度枚举。
        /// <para> <see cref="AESCryptographicKeySize" /> 类型的值。 </para>
        /// </param>
        /// <returns> 实现了 <see cref="ISymmetricAlgorithms" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="AES128AlgorithmsProvider" />
        /// <seealso cref="AES192AlgorithmsProvider" />
        /// <seealso cref="AES256AlgorithmsProvider" />
        /// <seealso cref="AESAlgorithmsProvider" />
        /// <seealso cref="AESCryptographicKeySize" />
        public static ISymmetricAlgorithms UseAES(this IFluentInterface fluent, AESCryptographicKeySize keySize = AESCryptographicKeySize.Default)
        {
            ISymmetricAlgorithms aes;
            switch (keySize)
            {
                case AESCryptographicKeySize.AES128:
                    aes = fluent.Service.GetService<AES128AlgorithmsProvider>();
                    break;

                case AESCryptographicKeySize.AES192:
                    aes = fluent.Service.GetService<AES192AlgorithmsProvider>();
                    break;

                case AESCryptographicKeySize.AES256:
                    aes = fluent.Service.GetService<AES256AlgorithmsProvider>();
                    break;

                default:
                    aes = fluent.Service.GetService<AESAlgorithmsProvider>();
                    break;
            }
            return aes;
        }

        /// <summary> 使用程序集注解助手。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="IAttributeHelper{TTarget}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IAttributeHelper{TTarget}" />
        /// <seealso cref="Assembly" />
        /// <seealso cref="AssemblyAttributeHelper" />
        public static IAttributeHelper<Assembly> UseAssemblyAttributeHelper(this IFluentInterface fluent)
            => fluent.Service.GetService<AssemblyAttributeHelper>();

        /// <summary> 使用异步的 AES 对称加密算法。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <param name="keySize">
        /// AES 算法密钥长度枚举。
        /// <para> <see cref="AESCryptographicKeySize" /> 类型的值。 </para>
        /// </param>
        /// <returns> 实现了 <see cref="ISymmetricAlgorithms" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="IAsyncSymmetricAlgorithms" />
        /// <seealso cref="AES128AlgorithmsProvider" />
        /// <seealso cref="AES192AlgorithmsProvider" />
        /// <seealso cref="AES256AlgorithmsProvider" />
        /// <seealso cref="AESAlgorithmsProvider" />
        /// <seealso cref="AESCryptographicKeySize" />
        public static IAsyncSymmetricAlgorithms UseAsyncAES(this IFluentInterface fluent, AESCryptographicKeySize keySize = AESCryptographicKeySize.Default)
        {
            IAsyncSymmetricAlgorithms aes;
            switch (keySize)
            {
                case AESCryptographicKeySize.AES128:
                    aes = fluent.Service.GetService<AES128AlgorithmsProvider>();
                    break;

                case AESCryptographicKeySize.AES192:
                    aes = fluent.Service.GetService<AES192AlgorithmsProvider>();
                    break;

                case AESCryptographicKeySize.AES256:
                    aes = fluent.Service.GetService<AES256AlgorithmsProvider>();
                    break;

                default:
                    aes = fluent.Service.GetService<AESAlgorithmsProvider>();
                    break;
            }
            return aes;
        }

        /// <summary> 使用异步的程序集注解助手。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns>
        /// 实现了 <see cref="IAsyncAttributeHelper{TTarget}" /> 类型接口的对象实例。
        /// </returns>
        /// <seealso cref="IAttributeHelper{TTarget}" />
        /// <seealso cref="IAsyncAttributeHelper{TTarget}" />
        /// <seealso cref="Assembly" />
        /// <seealso cref="AssemblyAttributeHelper" />
        public static IAsyncAttributeHelper<Assembly> UseAsyncAssemblyAttributeHelper(this IFluentInterface fluent)
            => fluent.Service.GetService<AssemblyAttributeHelper>();

        /// <summary> 使用异步的 DES 对称加密算法。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="ISymmetricAlgorithms" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="IAsyncSymmetricAlgorithms" />
        /// <seealso cref="DESAlgorithmsProvider" />
        public static IAsyncSymmetricAlgorithms UseAsyncDES(this IFluentInterface fluent)
            => fluent.Service.GetService<DESAlgorithmsProvider>();

        /// <summary> 使用异步的访问环境变量的方法。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="IEnvironmentVariableAccessor" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IEnvironmentVariableAccessor" />
        /// <seealso cref="IAsyncEnvironmentVariableAccessor" />
        /// <seealso cref="EnvironmentVariableAccessor" />
        public static IAsyncEnvironmentVariableAccessor UseAsyncEnvironmentVariableAccessor(this IFluentInterface fluent)
            => fluent.Service.GetService<EnvironmentVariableAccessor>();

        /// <summary> 使用异步的基于 Newtonsoft.Json 的序列化方法。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="IJsonSerializerExtensions" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IJsonSerializerExtensions" />
        /// <seealso cref="IAsyncJsonSerializerExtensions" />
        /// <seealso cref="ISerializer" />
        /// <seealso cref="JsonSerializer" />
        public static IAsyncJsonSerializerExtensions UseAsyncJsonSerializer(this IFluentInterface fluent)
            => fluent.Service.GetService<JsonSerializer>();

        /// <summary> 使用异步的成员注解助手。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns>
        /// 实现了 <see cref="IAsyncAttributeHelper{TTarget}" /> 类型接口的对象实例。
        /// </returns>
        /// <seealso cref="IAttributeHelper{TTarget}" />
        /// <seealso cref="IAsyncAttributeHelper{TTarget}" />
        /// <seealso cref="MemberInfo" />
        /// <seealso cref="MemberAttributeHelper" />
        public static IAsyncAttributeHelper<MemberInfo> UseAsyncMemberAttributeHelper(this IFluentInterface fluent)
            => fluent.Service.GetService<MemberAttributeHelper>();

        /// <summary> 使用异步的 XML 序列化方法。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="ISerializer" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="ISerializer" />
        /// <seealso cref="IAsyncSerializer" />
        /// <seealso cref="XmlSerializer" />
        public static IAsyncSerializer UseAsyncXmlSerializer(this IFluentInterface fluent)
            => fluent.Service.GetService<XmlSerializer>();

        /// <summary> 使用 DES 对称加密算法。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="ISymmetricAlgorithms" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="ISymmetricAlgorithms" />
        /// <seealso cref="DESAlgorithmsProvider" />
        public static ISymmetricAlgorithms UseDES(this IFluentInterface fluent)
            => fluent.Service.GetService<DESAlgorithmsProvider>();

        /// <summary> 使用访问环境变量的方法。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="IEnvironmentVariableAccessor" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IEnvironmentVariableAccessor" />
        /// <seealso cref="EnvironmentVariableAccessor" />
        public static IEnvironmentVariableAccessor UseEnvironmentVariableAccessor(this IFluentInterface fluent)
            => fluent.Service.GetService<EnvironmentVariableAccessor>();

        /// <summary> 使用生成 <see cref="Guid" /> 类型 ID 的方法。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="IIDGenerateUtilities{T}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IIDGenerateUtilities{T}" />
        /// <seealso cref="Guid" />
        /// <seealso cref="GuidGenerator" />
        public static IIDGenerateUtilities<Guid> UseGuidGenerator(this IFluentInterface fluent)
            => fluent.Service.GetService<GuidGenerator>();

        /// <summary> 使用哈希算法工厂类。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="IHashAlgorithmsFactory" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IHashAlgorithmsFactory" />
        /// <seealso cref="HashAlgorithmsFactory" />
        public static IHashAlgorithmsFactory UseHashAlgorithmsFactory(this IFluentInterface fluent)
            => fluent.Service.GetService<HashAlgorithmsFactory>();

        /// <summary> 使用 <see cref="long" /> 类型的哈希格式化程序。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="IHashIdFormatter{T}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IHashIdFormatter{T}" />
        /// <seealso cref="Int32HashFormatter" />
        public static IHashIdFormatter<long> UseInt64HashFormatter(this IFluentInterface fluent)
            => fluent.Service.GetService<Int64HashFormatter>();

        /// <summary> 使用 <see cref="int" /> 类型的哈希格式化程序。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="IHashIdFormatter{T}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IHashIdFormatter{T}" />
        /// <seealso cref="Int32HashFormatter" />
        public static IHashIdFormatter<int> UseIntHashFormatter(this IFluentInterface fluent)
            => fluent.Service.GetService<Int32HashFormatter>();

        /// <summary> 使用基于 Newtonsoft.Json 的序列化方法。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="IJsonSerializerExtensions" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IJsonSerializerExtensions" />
        /// <seealso cref="ISerializer" />
        /// <seealso cref="JsonSerializer" />
        public static IJsonSerializerExtensions UseJsonSerializer(this IFluentInterface fluent)
            => fluent.Service.GetService<JsonSerializer>();

        /// <summary> 使用成员注解助手。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="IAttributeHelper{TTarget}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IAttributeHelper{TTarget}" />
        /// <seealso cref="MemberInfo" />
        /// <seealso cref="MemberAttributeHelper" />
        public static IAttributeHelper<MemberInfo> UseMemberAttributeHelper(this IFluentInterface fluent)
            => fluent.Service.GetService<MemberAttributeHelper>();

        /// <summary> 使用生成 NanoId 格式 ID 的方法。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns>
        /// 实现了 <see cref="IStringifyIDGenerateUtilities" /> 类型接口的对象实例。
        /// </returns>
        /// <seealso cref="IStringifyIDGenerateUtilities" />
        /// <seealso cref="IIDGenerateUtilities{T}" />
        /// <seealso cref="NanoidGenerator" />
        public static IStringifyIDGenerateUtilities UseNanoIdGenerator(this IFluentInterface fluent)
            => fluent.Service.GetService<NanoidGenerator>();

        /// <summary> 使用随机密码生成程序。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="IPasswordGenerateUtilities" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IPasswordGenerateUtilities" />
        /// <seealso cref="RandomPasswordGenerator" />
        public static IPasswordGenerateUtilities UseRandomPasswordGenerator(this IFluentInterface fluent)
            => fluent.Service.GetService<RandomPasswordGenerator>();

        /// <summary> 使用 XML 序列化方法。 </summary>
        /// <param name="fluent"> 实现了 <see cref="IFluentInterface" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="ISerializer" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="ISerializer" />
        /// <seealso cref="XmlSerializer" />
        public static ISerializer UseXmlSerializer(this IFluentInterface fluent)
            => fluent.Service.GetService<XmlSerializer>();
    }
}