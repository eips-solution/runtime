/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了默认选项标记的接口。 </summary>
    /// <typeparam name="T"> 默认选项标记类型。 </typeparam>
    public interface IDefaultOptions<T> where T : struct
    {
        /// <summary> 是否默认的选项。 </summary>
        /// <value> 设置或获取一个值，用于表示是否默认的选项。 </value>
        T Default { get; }
    }
}