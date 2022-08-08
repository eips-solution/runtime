/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了标识是否可见的接口。 </summary>
    /// <typeparam name="T"> 标识是否可见的类型。 </typeparam>
    public interface IVisibility<T> where T : struct
    {
        /// <summary> 是否隐藏。 </summary>
        /// <value> 获取一个值，用于表示是否隐藏。 </value>
        T Hidden { get; }

        /// <summary> 是否可见。 </summary>
        /// <value> 设置或获取一个值，用于表示是否可见。 </value>
        T Visible { get; set; }
    }
}