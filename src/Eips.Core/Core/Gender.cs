/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips
{
    /// <summary> 定义了性别枚举类型。 </summary>
    public enum Gender
    {
        /// <summary> 女性。 </summary>
        Female = 0x46,

        /// <summary> 男性。 </summary>
        Male = 0x4D,

        /// <summary> 未提供。 </summary>
        NotSupport = 0x4E,

        /// <summary> 未知的。 </summary>
        Unknown = 0x55,

        /// <summary> 默认的。等效于 <see cref="NotSupport" />。 </summary>
        Default = NotSupport
    }
}