/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Collections.Generic;

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 提供了创建哈希算法实例相关的方法。 </summary>
    /// <seealso cref="IHashAlgorithmsFactory" />
    public partial class HashAlgorithmsFactory : IHashAlgorithmsFactory
    {
#if !NET40

        private readonly IDictionary<SupportedHashAlgorithms, IAsyncHashAlgorithms> m_asyncHashAlgs
            = new Dictionary<SupportedHashAlgorithms, IAsyncHashAlgorithms>();

#endif

        private readonly IDictionary<SupportedHashAlgorithms, IHashAlgorithms> m_hashAlgs
                    = new Dictionary<SupportedHashAlgorithms, IHashAlgorithms>();

        /// <summary> 用于初始化一个 <see cref="HashAlgorithmsFactory" /> 类型的对象实例。 </summary>
        public HashAlgorithmsFactory()
        {
            m_hashAlgs.Add(SupportedHashAlgorithms.MD5, new MD5AlgorithmsProvider());
            m_hashAlgs.Add(SupportedHashAlgorithms.SHA1, new SHA1AlgorithmsProvider());
            m_hashAlgs.Add(SupportedHashAlgorithms.SHA256, new SHA256AlgorithmsProvider());
            m_hashAlgs.Add(SupportedHashAlgorithms.SHA384, new SHA384AlgorithmsProvider());
            m_hashAlgs.Add(SupportedHashAlgorithms.SHA512, new SHA512AlgorithmsProvider());

#if !NET40

            m_asyncHashAlgs.Add(SupportedHashAlgorithms.MD5, new MD5AlgorithmsProvider());
            m_asyncHashAlgs.Add(SupportedHashAlgorithms.SHA1, new SHA1AlgorithmsProvider());
            m_asyncHashAlgs.Add(SupportedHashAlgorithms.SHA256, new SHA256AlgorithmsProvider());
            m_asyncHashAlgs.Add(SupportedHashAlgorithms.SHA384, new SHA384AlgorithmsProvider());
            m_asyncHashAlgs.Add(SupportedHashAlgorithms.SHA512, new SHA512AlgorithmsProvider());

#endif
        }

        /// <summary>
        /// 创建哈希算法。
        /// <para> 实现了 <see cref="IHashAlgorithms" /> 类型接口的对象实例。 </para>
        /// </summary>
        /// <param name="alg">
        /// 哈希算法。
        /// <para> <see cref="SupportedHashAlgorithms" /> 类型的值。 </para>
        /// </param>
        /// <returns>
        /// 哈希算法对象实例。
        /// <para> 实现了 <see cref="IHashAlgorithms" /> 类型接口的对象实例。 </para>
        /// </returns>
        /// <seealso cref="IHashAlgorithms" />
        /// <seealso cref="SupportedHashAlgorithms" />
        public IHashAlgorithms Create(SupportedHashAlgorithms alg = SupportedHashAlgorithms.MD5) => m_hashAlgs[alg];
    }
}