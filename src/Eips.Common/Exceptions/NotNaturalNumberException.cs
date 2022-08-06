/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Globalization;
using System;

namespace Niacomsoft.Eips
{
    /// <summary>
    /// 当数值小于 0 时，将引发此类型的异常。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="Exception" />
    public sealed class NotNaturalNumberException : Exception
    {
        /// <summary> 用于初始化一个 <see cref="NotNaturalNumberException" /> 类型的对象实例。 </summary>
        /// <param name="value"> <see cref="int" /> 类型的值。 </param>
        public NotNaturalNumberException(int value) : base(SR.Format("NotNaturalNumberException_default_message", value))
        {
        }

        /// <summary> 用于初始化一个 <see cref="NotNaturalNumberException" /> 类型的对象实例。 </summary>
        /// <param name="value"> <see cref="long" /> 类型的值。 </param>
        public NotNaturalNumberException(long value) : base(SR.Format("NotNaturalNumberException_default_message", value))
        {
        }

        /// <summary> 用于初始化一个 <see cref="NotNaturalNumberException" /> 类型的对象实例。 </summary>
        /// <param name="value"> <see cref="short" /> 类型的值。 </param>
        public NotNaturalNumberException(short value) : base(SR.Format("NotNaturalNumberException_default_message", value))
        {
        }

        /// <summary>
        /// 当 <paramref name="value" /> 小于 0 时，将引发一个
        /// <see cref="NotNaturalNumberException" /> 类型的异常。
        /// </summary>
        /// <param name="value"> <see cref="int" /> 类型的值。 </param>
        /// <exception cref="NotNaturalNumberException" />
        public static void Throw(int value)
        {
            if (ValueTypeComparer.Compare(value, symbol: NumberComparisonSymbols.LessThan))
                throw new NotNaturalNumberException(value);
        }

        /// <summary>
        /// 当 <paramref name="value" /> 小于 0 时，将引发一个
        /// <see cref="NotNaturalNumberException" /> 类型的异常。
        /// </summary>
        /// <param name="value"> <see cref="long" /> 类型的值。 </param>
        /// <exception cref="NotNaturalNumberException" />
        public static void Throw(long value)
        {
            if (ValueTypeComparer.Compare(value, symbol: NumberComparisonSymbols.LessThan))
                throw new NotNaturalNumberException(value);
        }

        /// <summary>
        /// 当 <paramref name="value" /> 小于 0 时，将引发一个
        /// <see cref="NotNaturalNumberException" /> 类型的异常。
        /// </summary>
        /// <param name="value"> <see cref="short" /> 类型的值。 </param>
        /// <exception cref="NotNaturalNumberException" />
        public static void Throw(short value)
        {
            if (ValueTypeComparer.Compare(value, symbol: NumberComparisonSymbols.LessThan))
                throw new NotNaturalNumberException(value);
        }
    }
}