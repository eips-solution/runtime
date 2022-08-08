/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了标记是否“必需”的接口。 </summary>
    /// <typeparam name="T"> 标识是否“必需”的类型。 </typeparam>
    public interface IRequired<T> where T : struct
    {
        /// <summary> 是否可选的。 </summary>
        /// <value> 获取一个值，用于表示是否可选的。 </value>
        T Optional { get; }

        /// <summary> 是否必需。 </summary>
        /// <value> 设置或获取一个值，用于表示是否必需。 </value>
        T Required { get; set; }
    }
}