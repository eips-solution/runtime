/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了标记是否激活的接口。 </summary>
    /// <typeparam name="T"> 标记是否激活的类型。 </typeparam>
    public interface IAvailable<T> where T : struct
    {
        /// <summary> 是否已经激活。 </summary>
        /// <value> 设置或获取一个值，用于表示是否已经激活。 </value>
        T Available { get; set; }

        /// <summary> 是否尚未激活。 </summary>
        /// <value> 获取一个值，用于表示是否尚未激活。 </value>
        T Unavailable { get; }
    }
}