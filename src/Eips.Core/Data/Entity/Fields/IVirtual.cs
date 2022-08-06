/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了标识是否虚拟的接口。 </summary>
    /// <typeparam name="T"> 标记是否虚拟的类型。 </typeparam>
    public interface IVirtual<T> where T : struct
    {
        /// <summary> 是否虚拟的。 </summary>
        /// <value> 设置或获取一个值，用于表示是否虚拟的。 </value>
        T Virtual { get; set; }
    }
}