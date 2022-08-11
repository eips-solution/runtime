/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Globalization;
using System;

namespace Niacomsoft.Eips.Security
{
    /// <summary>
    /// 当生成密码的字母表字符串长度小于 8 时，将引发此类型的异常。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="Exception" />
    public sealed class IncorrectPasswordAlphabetLengthException : Exception
    {
        /// <summary>
        /// 用于初始化一个 <see cref="IncorrectPasswordAlphabetLengthException" /> 类型的对象实例。
        /// </summary>
        public IncorrectPasswordAlphabetLengthException() : base(SR.GetString("IncorrectPasswordAlphabetLengthException_default_message"))
        {
        }
    }
}