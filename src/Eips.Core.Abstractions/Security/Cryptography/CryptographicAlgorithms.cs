﻿/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Globalization;
using System.Security.Cryptography;

namespace Niacomsoft.Eips.Security.Cryptography
{
    /// <summary> 提供了加密算法相关的基本方法。 </summary>
    public abstract class CryptographicAlgorithms
    {
        /// <summary>
        /// 当 <paramref name="data" /> 等于 <c> null </c> 或
        /// <paramref name="data" />.LongLength 等于 0 时，将引发一个
        /// <see cref="CryptographicException" /> 类型的异常。
        /// </summary>
        /// <param name="data"> 需要校验的字节数据。 </param>
        /// <exception cref="CryptographicException"> </exception>
        protected virtual void NullBinaryData(byte[] data)
        {
            if (ReferenceTypeEqualityComparer.None(data) || ValueTypeComparer.Compare(data.LongLength))
                throw new CryptographicException(SR.GetString("CryptographicException_invalid_byte_data"));
        }
    }
}