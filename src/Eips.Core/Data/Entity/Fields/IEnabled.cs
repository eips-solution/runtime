/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了标记是否可用的接口。 </summary>
    /// <typeparam name="T"> 标识是否可用的类型。 </typeparam>
    public interface IEnabled<T> where T : struct
    {
        /// <summary> 是否禁用。 </summary>
        /// <value> 获取一个值，用于表示是否禁用。 </value>
        T Disable { get; }

        /// <summary> 是否可用。 </summary>
        /// <value> 设置或获取一个值，用于表示是否可用。 </value>
        T Enable { get; set; }
    }
}