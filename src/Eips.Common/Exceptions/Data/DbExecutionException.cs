/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Globalization;
using System;

namespace Niacomsoft.Eips.Data
{
    /// <summary>
    /// 当执行数据库事务失败时，将引发此类型的异常。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="Exception" />
    public sealed class DbExecutionException : Exception
    {
        /// <summary> 用于初始化一个 <see cref="DbExecutionException" /> 类型的对象实例。 </summary>
        public DbExecutionException() : this(null)
        {
        }

        /// <summary> 用于初始化一个 <see cref="DbExecutionException" /> 类型的对象实例。 </summary>
        /// <param name="innerException">
        /// 引发此异常的 <see cref="Exception" /> 类型的对象实例。
        /// </param>
        public DbExecutionException(Exception innerException) : base(SR.GetString("DbExecutionException_default_message"), innerException)
        {
        }
    }
}