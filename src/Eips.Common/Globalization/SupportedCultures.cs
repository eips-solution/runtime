/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Globalization
{
    /// <summary> 定义了 Enterprise InPrivate SaaS (EIPS) 默认提供的文化区域枚举类型。 </summary>
    public enum SupportedCultures
    {
        /// <summary> 英语（美国） </summary>
        USA = 1033,

        /// <summary> 中文（中国） </summary>
        China = 2052,

        /// <summary> 中文（台湾） </summary>
        Taiwan = 1028,

        /// <summary> 默认的文化区域。等效于 <see cref="China" /> </summary>
        Default = China
    }
}