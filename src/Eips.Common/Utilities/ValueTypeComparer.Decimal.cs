/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips
{
    public partial class ValueTypeComparer
    {
        /// <summary> 比较 <paramref name="value1" /> 和 <paramref name="value2" />。 </summary>
        /// <param name="value1"> <see cref="decimal" /> 类型的值。 </param>
        /// <param name="value2"> <see cref="decimal" /> 类型的值。 </param>
        /// <param name="symbol">
        /// 数字对比符号。
        /// <para> <see cref="NumberComparisonSymbols" /> 类型的值。 </para>
        /// </param>
        /// <returns>
        /// 当 <paramref name="value1" /> 与 <paramref name="value2" /> 满足对比符号
        /// <paramref name="symbol" /> 时，则返回 <c> true </c>；否则返回 <c> false </c>。
        /// <para>
        /// 比如， <paramref name="symbol" /> 等于
        /// <see cref="NumberComparisonSymbols.GreaterThan" /> 时，则返回
        /// <paramref name="value1" /> &gt; <paramref name="value2" />。
        /// </para>
        /// </returns>
        /// <seealso cref="NumberComparisonSymbols" />
        public static bool Compare(decimal value1,
                                   decimal value2 = 0M,
                                   NumberComparisonSymbols symbol = NumberComparisonSymbols.Default)
        {
            bool result;
            switch (symbol)
            {
                case NumberComparisonSymbols.GreaterThan:
                    result = value1 > value2;
                    break;

                case NumberComparisonSymbols.GreaterThanOrEqual:
                    result = value1 >= value2;
                    break;

                case NumberComparisonSymbols.LessThan:
                    result = value1 < value2;
                    break;

                case NumberComparisonSymbols.LessThanOrEqual:
                    result = value1 <= value2;
                    break;

                default:
                    result = value1 == value2;
                    break;
            }

            return result;
        }
    }
}