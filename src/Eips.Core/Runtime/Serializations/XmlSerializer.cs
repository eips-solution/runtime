/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Diagnostics;
using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using XmlSerializeProvider = System.Xml.Serialization.XmlSerializer;

namespace Niacomsoft.Eips.Runtime.Serializations
{
    /// <summary>
    /// 提供了 XML 序列化相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="Serializer" />
    public sealed class XmlSerializer : Serializer
    {
        private readonly XmlSerializerNamespaces m_namespaceMgr;

        /// <summary> 用于初始化一个 <see cref="XmlSerializer" /> 类型的对象实例。 </summary>
        public XmlSerializer()
        {
            m_namespaceMgr = new XmlSerializerNamespaces();
            m_namespaceMgr.Add(XmlSerializerProperties.DefaultNamespacePrefix, XmlSerializerProperties.DefaultNamespace);
        }

        /// <summary> 用于初始化一个 <see cref="XmlSerializer" /> 类型的对象实例。 </summary>
        /// <param name="namespaces"> XML 序列化命名空间。 </param>
        public XmlSerializer(XmlSerializerNamespaces namespaces) : this()
        {
            if (ReferenceTypeEqualityComparer.NotNone(namespaces))
                m_namespaceMgr = namespaces;
        }

        /// <summary> 用于初始化一个 <see cref="XmlSerializer" /> 类型的对象实例。 </summary>
        /// <param name="ns"> 默认的 XML 序列化命名空间。 </param>
        /// <param name="prefixOfNs"> 默认的 XML 序列化命名空间前缀。 </param>
        public XmlSerializer(string ns, string prefixOfNs) : this()
        {
            if (!StringEqualityComparer.Empty(ns) && !StringEqualityComparer.Empty(prefixOfNs))
            {
                m_namespaceMgr.Add(prefixOfNs, ns);
            }
            else
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget<XmlSerializer>()
                                                             .WithMethod("Constructor")
                                                             .WithMessage($"XML 命名空间 “{nameof(ns)}” 或前缀 “{nameof(prefixOfNs)}” 可能为空。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);
            }
        }

        /// <summary>
        /// 从流 <paramref name="deserializeStream" /> 中反序列化得到
        /// <typeparamref name="T" /> 类型的对象实例。
        /// </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="deserializeStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <seealso cref="Stream" />
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="deserializeStream" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        public override T Deserialize<T>(Stream deserializeStream)
        {
            if (ReferenceTypeEqualityComparer.None(deserializeStream))
            {
                throw new ArgumentNullException(nameof(deserializeStream));
            }

            return new XmlSerializeProvider(typeof(T)).Deserialize(deserializeStream) as T;
        }

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并写入流 <paramref name="serializeStream" />。 </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="obj"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <param name="serializeStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <seealso cref="Stream" />
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="serializeStream" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        public override void Serialize<T>(T obj, Stream serializeStream)
        {
            if (ReferenceTypeEqualityComparer.NotNone(obj))
            {
                if (ReferenceTypeEqualityComparer.None(serializeStream))
                {
                    throw new ArgumentNullException(nameof(serializeStream));
                }

                new XmlSerializeProvider(typeof(T)).Serialize(serializeStream, obj, m_namespaceMgr);
            }
            else
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget<XmlSerializer>()
                                                             .WithMethod(nameof(Serialize))
                                                             .WithMessage($"“{typeof(T).FullName}” 类型的参数 “{nameof(obj)}” 等于 null，将忽略 XML 序列化操作。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);
            }
        }
    }
}