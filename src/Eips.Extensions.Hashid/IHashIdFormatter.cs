/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using HashidsNet;

namespace Niacomsoft.Eips.Extensions
{
    /// <summary> 定义了数值哈希字符串格式化的接口。 </summary>
    /// <typeparam name="T">
    /// 值类型。
    /// <para> 仅支持 <see cref="int" /> 和 <see cref="long" /> 类型的数值。 </para>
    /// </typeparam>
    /// <seealso cref="HashidsNet.Hashids" href="https://www.nuget.org/packages/Hashids.net" />
    public interface IHashIdFormatter<T>
        where T : struct
    {
        /// <summary> 生成加密密钥的方法。 </summary>
        /// <value> 获取 <see cref="IHashIdCryptographyKeyProvider" /> 类型的对象实例，用于表示生成加密密钥的方法。 </value>
        /// <seealso cref="IHashIdCryptographyKeyProvider" />
        IHashIdCryptographyKeyProvider KeyProvider { get; }

        /// <summary> 计算哈希格式数值的方法。 </summary>
        /// <value> 获取 <see cref="IHashids" /> 类型的对象实例，用于表示计算哈希格式数值的方法。 </value>
        /// <seealso cref="IHashids" href="https://www.nuget.org/packages/Hashids.net" />
        IHashids Provider { get; }

        /// <summary>
        /// 从哈希字符串 <paramref name="hashStr" /> 还原 <typeparamref name="T" /> 类型的值。
        /// </summary>
        /// <param name="hashStr"> 哈希字符串。 </param>
        /// <returns>
        /// 可为空的 <typeparamref name="T" /> 类型的值。
        /// <para>
        /// 当 <paramref name="hashStr" /> 等于 <c> null </c>、
        /// <see cref="string.Empty" /> 或者空格符时，则返回 <c> null </c>。
        /// </para>
        /// </returns>
        T? FromString(string hashStr);

        /// <summary> 将数值 <paramref name="value" /> 转换成哈希字符串。 </summary>
        /// <param name="value"> <typeparamref name="T" /> 类型的值。 </param>
        /// <returns> 哈希字符串。 </returns>
        string ToString(T value);
    }
}