/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了标记是否系统内置的接口。 </summary>
    /// <typeparam name="T"> 标记是否系统内置的类型。 </typeparam>
    public interface IBuiltIn<T> where T : struct
    {
        /// <summary> 是否系统内置的。 </summary>
        /// <value> 设置或获取一个值，用于表示是否系统内置的。 </value>
        T BuiltIn { get; set; }

        /// <summary> 是否非系统内置的。 </summary>
        /// <value> 获取一个值，用于表示是否非系统内置的。 </value>
        T NotBuiltIn { get; }
    }
}