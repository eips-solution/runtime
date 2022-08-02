/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips
{
    /// <summary> 定义了空白字符串比较选项枚举类型。 </summary>
    public enum EmptyCompareOptions
    {
        /// <summary> 对比时不仅比较 <see cref="string.Empty" />，还需要比较空格符。 </summary>
        IncludeWhiteSpace = 1,

        /// <summary> 仅比较 <see cref="string.Empty" />。 </summary>
        OnlyEmpty = 2,

        /// <summary> 仅比较是否等于 <c> null </c>。 </summary>
        OnlyNull = 3,

        /// <summary> 默认的选项。等效于 <see cref="IncludeWhiteSpace" />。 </summary>
        Default = IncludeWhiteSpace
    }
}