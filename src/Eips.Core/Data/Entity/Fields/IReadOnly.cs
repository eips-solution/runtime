/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了标识是否只读的接口。 </summary>
    /// <typeparam name="T"> 是否只读。 </typeparam>
    public interface IReadOnly<T>
        where T : struct
    {
        /// <summary> 是否只读。 </summary>
        /// <value> 设置或获取一个值，用于表示是否只读。 </value>
        T ReadOnly { get; set; }

        /// <summary> 是否可写。 </summary>
        /// <value> 获取一个值，用于表示是否可写。 </value>
        T Writable { get; }
    }
}