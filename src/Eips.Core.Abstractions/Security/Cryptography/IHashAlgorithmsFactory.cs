/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 定义了创建哈希算法的工厂接口。 </summary>
    public interface IHashAlgorithmsFactory
    {
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
        IHashAlgorithms Create(SupportedHashAlgorithms alg = SupportedHashAlgorithms.Default);

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
        IAsyncHashAlgorithms CreateAsynchronous(SupportedHashAlgorithms alg = SupportedHashAlgorithms.Default);
    }
}