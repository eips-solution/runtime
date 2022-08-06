/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Extensions
{
    /// <summary>
    /// 提供了计算 <see cref="int" /> 类型哈希格式化相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="IHashIdFormatter{T}" />
    /// <seealso cref="HashIdFormatter{T}" />
    public sealed class Int32HashFormatter : HashIdFormatter<int>, IHashIdFormatter<int>
    {
        /// <summary> 用于初始化一个 <see cref="Int32HashFormatter" /> 类型的对象实例。 </summary>
        /// <param name="keyProvider"> 创建加密密钥的方法。 </param>
        public Int32HashFormatter(IHashIdCryptographyKeyProvider keyProvider) : base(keyProvider)
        {
        }

        /// <summary>
        /// 从哈希字符串 <paramref name="hashStr" /> 还原 <see cref="int" /> 类型的值。
        /// </summary>
        /// <param name="hashStr"> 哈希字符串。 </param>
        /// <returns>
        /// 可为空的 <see cref="int" /> 类型的值。
        /// <para>
        /// 当 <paramref name="hashStr" /> 等于 <c> null </c>、
        /// <see cref="F:System.String.Empty" /> 或者空格符时，则返回 <c> null </c>。
        /// </para>
        /// </returns>
        /// <exception cref="System.OverflowException">
        /// 当调用 <see cref="HashidsNet.IHashids.DecodeSingle(string)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        /// <exception cref="HashidsNet.NoResultException">
        /// 当调用 <see cref="HashidsNet.IHashids.DecodeSingle(string)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        public override int? FromString(string hashStr)
        {
            if (StringEqualityComparer.Empty(hashStr)) return null;
            return Provider.DecodeSingle(hashStr);
        }

        /// <summary> 将数值 <paramref name="value" /> 转换成哈希字符串。 </summary>
        /// <param name="value"> <see cref="int" /> 类型的值。 </param>
        /// <returns> 哈希字符串。 </returns>
        /// <exception cref="NotNaturalNumberException">
        /// 当 <paramref name="value" /> 不是一个自然数时，将引发此类型的异常。
        /// </exception>
        public override string ToString(int value)
        {
            NotNaturalNumberException.Throw(value);
            return Provider.Encode(value);
        }
    }
}