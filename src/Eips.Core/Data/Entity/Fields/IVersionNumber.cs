/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了版本号数字接口。 </summary>
    public interface IVersionNumber
    {
        /// <summary> 数据版本号。 </summary>
        /// <value> 设置或获取一个值，用于表示数据版本号。 </value>
        double Version { get; set; }
    }
}