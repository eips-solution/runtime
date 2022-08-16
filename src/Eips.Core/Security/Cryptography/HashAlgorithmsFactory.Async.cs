/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips.Security.Cryptography
{
    public partial class HashAlgorithmsFactory
    {
        /// <summary>
        /// 创建异步的哈希算法。
        /// <para> 实现了 <see cref="IAsyncHashAlgorithms" /> 类型接口的对象实例。 </para>
        /// </summary>
        /// <param name="alg">
        /// 哈希算法。
        /// <para> <see cref="SupportedHashAlgorithms" /> 类型的值。 </para>
        /// </param>
        /// <returns>
        /// 异步的哈希算法实例。
        /// <para> 实现了 <see cref="IAsyncHashAlgorithms" /> 类型接口的对象实例。 </para>
        /// </returns>
        /// <seealso cref="IAsyncHashAlgorithms" />
        /// <seealso cref="SupportedHashAlgorithms" />
        public IAsyncHashAlgorithms CreateAsynchronous(SupportedHashAlgorithms alg = SupportedHashAlgorithms.MD5)
        {
#if !NET40
            return m_asyncHashAlgs[alg];

#else

            throw new NotImplementedException();
#endif
        }
    }
}