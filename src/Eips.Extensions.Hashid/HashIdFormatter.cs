/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using HashidsNet;
using Niacomsoft.Eips.Diagnostics;
using System.Diagnostics;

namespace Niacomsoft.Eips.Extensions
{
    /// <summary> 提供了数值哈希格式化相关的基本方法。 </summary>
    /// <typeparam name="T">
    /// 值类型。
    /// <para> 仅支持 <see cref="int" /> 和 <see cref="long" /> 类型。 </para>
    /// </typeparam>
    public abstract class HashIdFormatter<T> : IHashIdFormatter<T>
        where T : struct
    {
        /// <summary> 用于初始化一个 <see cref="HashIdFormatter{T}" /> 类型的对象实例。 </summary>
        /// <param name="keyProvider"> 创建加密密钥的方法。 </param>
        protected HashIdFormatter(IHashIdCryptographyKeyProvider keyProvider)
        {
            KeyProvider = ParameterGuard.SafeGet(keyProvider, () => new HashIdCryptographyKeyProvider());
            Provider = new Hashids(salt: ParameterGuard.SafeGet(keyProvider?.Key, string.Empty, EmptyCompareOptions.OnlyNull));
        }

        /// <summary>
        /// 校验字符串 <paramref name="s" /> 是否等于 <c> null </c>、
        /// <see cref="string.Empty" /> 或者空格符。
        /// </summary>
        /// <param name="s"> 哈希字符串。 </param>
        /// <returns>
        /// 当字符串 <paramref name="s" /> 等于 <c> null </c>、
        /// <see cref="string.Empty" /> 或者空格符时，则返回 <c> true </c>；否则返回 <c> false </c>。
        /// </returns>
        protected virtual bool InvalidHashString(string s)
        {
            if (StringEqualityComparer.Empty(s))
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget(GetType())
                                                             .WithMethod(nameof(FromString))
                                                             .WithMessage($"无法将空白字符串转换成 {typeof(T).FullName} 类型值。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);
                return true;
            }
            return false;
        }

        /// <summary> 生成加密密钥的方法。 </summary>
        /// <value> 获取 <see cref="IHashIdCryptographyKeyProvider" /> 类型的对象实例，用于表示生成加密密钥的方法。 </value>
        /// <seealso cref="IHashIdCryptographyKeyProvider" />
        public virtual IHashIdCryptographyKeyProvider KeyProvider
        {
            get;
        }

        /// <summary> 计算哈希格式数值的方法。 </summary>
        /// <value> 获取 <see cref="IHashids" /> 类型的对象实例，用于表示计算哈希格式数值的方法。 </value>
        /// <seealso cref="IHashids" href="https://www.nuget.org/packages/Hashids.net" />
        public virtual IHashids Provider
        {
            get;
        }

        /// <summary>
        /// 从哈希字符串 <paramref name="hashStr" /> 还原 <typeparamref name="T" /> 类型的值。
        /// </summary>
        /// <param name="hashStr"> 哈希字符串。 </param>
        /// <returns>
        /// 可为空的 <typeparamref name="T" /> 类型的值。
        /// <para>
        /// 当 <paramref name="hashStr" /> 等于 <c> null </c>、
        /// <see cref="F:System.String.Empty" /> 或者空格符时，则返回 <c> null </c>。
        /// </para>
        /// </returns>
        public abstract T? FromString(string hashStr);

        /// <summary> 将数值 <paramref name="value" /> 转换成哈希字符串。 </summary>
        /// <param name="value"> <typeparamref name="T" /> 类型的值。 </param>
        /// <returns> 哈希字符串。 </returns>
        public abstract string ToString(T value);
    }
}