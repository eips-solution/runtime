/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips
{
    /// <summary> 定义了数字比较符号枚举类型。 </summary>
    public enum NumberComparisonSymbols
    {
        /// <summary> 等于号。 </summary>
        Equal = 1,

        /// <summary> 大于号。 </summary>
        GreaterThan = 2,

        /// <summary> 大于等于号。 </summary>
        GreaterThanOrEqual = 3,

        /// <summary> 小于号。 </summary>
        LessThan = 4,

        /// <summary> 小于等于号。 </summary>
        LessThanOrEqual = 5,

        /// <summary>
        /// 默认的。
        /// <para> 等效于 <see cref="Equal" />。 </para>
        /// </summary>
        Default = Equal
    }
}