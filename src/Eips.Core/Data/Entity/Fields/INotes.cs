/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了标记数据实体备注信息的接口。 </summary>
    public interface INotes
    {
        /// <summary> 备注信息。 </summary>
        /// <value> 设置或获取一个字符串，用于表示备注信息。 </value>
        string Notes { get; set; }
    }
}