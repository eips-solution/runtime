/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Diagnostics;
using Niacomsoft.Eips.Reflection;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace Niacomsoft.Eips.Runtime.Serializations
{
    /// <summary>
    /// 提供了二进制序列化相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="Serializer" />
    [Obsolete("Warning: This serialization method is deprecated.", false)]
    public sealed class BinarySerializer : Serializer
    {
        private readonly IAttributeHelper<MemberInfo> m_attributeHelper;
        private readonly BinaryFormatter m_provider = new BinaryFormatter();

        /// <summary>
        /// 当 <paramref name="type" /> 时，将引发一个
        /// <see cref="TypeAnnotationNotFoundException" /> 类型的异常。
        /// </summary>
        /// <param name="type"> 数据类型。 </param>
        /// <seealso cref="Type" />
        /// <exception cref="TypeAnnotationNotFoundException"> </exception>
        private void SerializableAttributeNotFound(Type type)
        {
            var attributes = ParameterGuard.SafeGet(m_attributeHelper, () => MemberAttributeHelper.Instance).GetCustomAttributes<SerializableAttribute>(type);
            if (ReferenceTypeEqualityComparer.None(attributes) || ValueTypeComparer.Compare(attributes.Count()))
            {
                throw new TypeAnnotationNotFoundException(type, typeof(SerializableAttribute));
            }
        }

        /// <summary> 用于初始化一个 <see cref="BinarySerializer" /> 类型的对象实例。 </summary>
        /// <param name="memberAttribute">
        /// 访问程序注解的方法。
        /// <para> 实现了 <see cref="IAsyncAttributeHelper{TTarget}" /> 类型接口的对象实例。 </para>
        /// </param>
        /// <seealso cref="IAttributeHelper{TTarget}" />
        /// <seealso cref="MemberInfo" />
        public BinarySerializer(IAttributeHelper<MemberInfo> memberAttribute)
        {
            m_attributeHelper = memberAttribute;
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
        /// <exception cref="TypeAnnotationNotFoundException">
        /// 当 <typeparamref name="T" /> 类型中未找到
        /// <see cref="SerializableAttribute" /> 注解时，将引发此类型的异常。
        /// </exception>
        /// <exception cref="System.Runtime.Serialization.SerializationException">
        /// 当调用 <see cref="BinaryFormatter.Deserialize(Stream)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        /// <exception cref="System.Security.SecurityException">
        /// 当调用 <see cref="BinaryFormatter.Deserialize(Stream)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// 当调用 <see cref="BinaryFormatter.Deserialize(Stream)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        public override T Deserialize<T>(Stream deserializeStream)
        {
            if (ReferenceTypeEqualityComparer.None(deserializeStream))
            {
                throw new ArgumentNullException(nameof(deserializeStream));
            }
            SerializableAttributeNotFound(typeof(T));
            return m_provider.Deserialize(deserializeStream) as T;
        }

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并写入流 <paramref name="serializeStream" />。 </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="obj"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <param name="serializeStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <seealso cref="Stream" />
        /// <exception cref="ArgumentNullException">
        /// 当 <paramref name="serializeStream" /> 等于 <c> null </c> 时，将引发此类型的异常。
        /// </exception>
        /// <exception cref="TypeAnnotationNotFoundException">
        /// 当 <typeparamref name="T" /> 类型中未找到
        /// <see cref="SerializableAttribute" /> 注解时，将引发此类型的异常。
        /// </exception>
        /// <exception cref="System.Runtime.Serialization.SerializationException">
        /// 当调用 <see cref="BinaryFormatter.Serialize(Stream, object)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        /// <exception cref="System.Security.SecurityException">
        /// 当调用 <see cref="BinaryFormatter.Serialize(Stream, object)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// 当调用 <see cref="BinaryFormatter.Serialize(Stream, object)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        public override void Serialize<T>(T obj, Stream serializeStream)
        {
            if (ReferenceTypeEqualityComparer.NotNone(obj))
            {
                if (ReferenceTypeEqualityComparer.None(serializeStream))
                {
                    throw new ArgumentNullException(nameof(serializeStream));
                }

                SerializableAttributeNotFound(typeof(T));

                m_provider.Serialize(serializeStream, obj);
            }
            else
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget<BinarySerializer>()
                                                             .WithMethod(nameof(Serialize))
                                                             .WithMessage($"“{nameof(obj)}” 等于 null，忽略序列化。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);
            }
        }
    }
}