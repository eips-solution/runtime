/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了自动生成 ID 字段接口。 </summary>
    /// <typeparam name="T"> 自动生成 ID 字段类型。 </typeparam>
    public interface IAutoGenerationId<T> where T : struct
    {
        /// <summary> 自动 ID。 </summary>
        /// <value> 设置或获取一个 <typeparamref name="T" /> 类型的值，用于表示自动 ID。 </value>
        T AutoId { get; set; }
    }
}