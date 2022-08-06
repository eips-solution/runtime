/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了数据实体唯一标识接口。 </summary>
    /// <typeparam name="T"> 数据实体唯一标识类型。 </typeparam>
    public interface IUniqueId<T>
    {
        /// <summary> 数据实体唯一标识。 </summary>
        /// <value> 设置或获取 <typeparamref name="T" /> 类型的对象实例或值，用于表示数据实体唯一标识。 </value>
        T Id { get; set; }
    }
}