/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Globalization;

namespace Niacomsoft.Eips.Extensions.Runtime.Serializations
{
    /// <summary> 提供了默认的 JSON 序列化配置相关的方法。 </summary>
    internal class DefaultJsonSerializerSettings
    {
#if DEBUG
        private const Formatting c_jsonDocumentFormatting = Formatting.Indented;
#else
        private const Formatting c_jsonDocumentFormatting = Formatting.None;
#endif

        /// <summary>
        /// 用于初始化一个 <see cref="DefaultJsonSerializerSettings" /> 类型的对象实例。
        /// </summary>
        private DefaultJsonSerializerSettings()
        {
        }

        /// <summary> 默认的 JSON 序列化设置。 </summary>
        /// <value>
        /// 获取 <see cref="JsonSerializerSettings" /> 类型的对象实例，用于表示默认的 JSON 序列化设置。
        /// </value>
        /// <seealso cref="JsonSerializerSettings" />
        internal static JsonSerializerSettings Default => new JsonSerializerSettings()
        {
            CheckAdditionalContent = false,
            ConstructorHandling = ConstructorHandling.Default,
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Culture = CultureInfo.CurrentCulture,
            DateFormatHandling = DateFormatHandling.MicrosoftDateFormat,
            DateFormatString = "yyyy-MM-dd",
            DateParseHandling = DateParseHandling.DateTime,
            DateTimeZoneHandling = DateTimeZoneHandling.Utc,
            DefaultValueHandling = DefaultValueHandling.Include,
            Error = (sender, e) =>
            {
                if (ReferenceTypeEqualityComparer.NotNone(e?.ErrorContext?.Error))
                    throw e.ErrorContext.Error;
            },
            FloatFormatHandling = FloatFormatHandling.Symbol,
            FloatParseHandling = FloatParseHandling.Double,
            Formatting = c_jsonDocumentFormatting,
            MaxDepth = 0x100,
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore,
            NullValueHandling = NullValueHandling.Include,
            ObjectCreationHandling = ObjectCreationHandling.Auto,
            PreserveReferencesHandling = PreserveReferencesHandling.None,
            ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            StringEscapeHandling = StringEscapeHandling.EscapeHtml,
            TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Full,
            TypeNameHandling = TypeNameHandling.Auto
        };
    }
}