/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了标记是否被冻结的接口。 </summary>
    /// <typeparam name="T"> 标记是否被冻结的类型。 </typeparam>
    public interface IFrozen<T> where T : struct
    {
        /// <summary> 是否被冻结。 </summary>
        /// <value> 设置或获取一个值，用于表示是否被冻结。 </value>
        T Frozen { get; set; }

        /// <summary> 是否未被冻结。 </summary>
        /// <value> 获取一个值，用于表示是否未被冻结。 </value>
        T Unfrozen { get; }
    }
}