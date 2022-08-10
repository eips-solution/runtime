/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Collections.Generic;

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 提供了创建哈希算法实例相关的方法。 </summary>
    /// <seealso cref="IHashAlgorithmsFactory" />
    public class HashAlgorithmsFactory : IHashAlgorithmsFactory
    {
        private readonly IDictionary<SupportedHashAlgorithms, IHashAlgorithms> ro_hashAlgs = new Dictionary<SupportedHashAlgorithms, IHashAlgorithms>();

        /// <summary> 用于初始化一个 <see cref="HashAlgorithmsFactory" /> 类型的对象实例。 </summary>
        public HashAlgorithmsFactory()
        {
            ro_hashAlgs.Add(SupportedHashAlgorithms.MD5, new MD5AlgorithmsProvider());
            ro_hashAlgs.Add(SupportedHashAlgorithms.SHA1, new SHA1AlgorithmsProvider());
            ro_hashAlgs.Add(SupportedHashAlgorithms.SHA256, new SHA256AlgorithmsProvider());
            ro_hashAlgs.Add(SupportedHashAlgorithms.SHA384, new SHA384AlgorithmsProvider());
            ro_hashAlgs.Add(SupportedHashAlgorithms.SHA512, new SHA512AlgorithmsProvider());
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
        public IHashAlgorithms Create(SupportedHashAlgorithms alg = SupportedHashAlgorithms.MD5) => ro_hashAlgs[alg];
    }
}