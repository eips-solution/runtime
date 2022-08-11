/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Globalization;
using System;

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 提供了访问对称加密算法密钥相关的基本方法。 </summary>
    /// <seealso cref="ISymmetricCryptographicKey" />
    public abstract class SymmetricCryptographicKey : ISymmetricCryptographicKey
    {
        /// <summary> 获取密钥字符串。 </summary>
        /// <returns> 密钥字符串。 </returns>
        protected abstract string InternalGetKeyString();

        /// <summary> 获取密钥字节数据。 </summary>
        /// <returns> 字节数组。 </returns>
        /// <seealso cref="System.Text.UTF8Encoding" />
        /// <exception cref="ArgumentException">
        /// 当方法 <see cref="InternalGetKeyString" /> 返回 <c> null </c> 或
        /// <see cref="string.Empty" /> 时，将引发此类型的异常。
        /// </exception>
        public virtual byte[] GetKeyData()
        {
            var keyString = InternalGetKeyString();
            if (StringEqualityComparer.Empty(keyString, EmptyCompareOptions.OnlyEmpty))
                throw new ArgumentException(SR.Format("ArgumentException_empty_or_whitespace", nameof(keyString)), nameof(keyString));
            return StringUtilities.GetBytes(keyString);
        }
    }
}