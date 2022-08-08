/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了标记锁定状态的接口。 </summary>
    /// <typeparam name="T"> 标记锁定状态的类型。 </typeparam>
    public interface ILocked<T> where T : struct
    {
        /// <summary> 是否锁定。 </summary>
        /// <value> 设置或获取一个值，用于表示是否锁定。 </value>
        T Locked { get; set; }

        /// <summary> 是否未锁定。 </summary>
        /// <value> 获取一个值，用于表示是否未锁定。 </value>
        T Unlock { get; }
    }
}