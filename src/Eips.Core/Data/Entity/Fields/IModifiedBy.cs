/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了标识数据实体最后修改人信息的接口。 </summary>
    /// <typeparam name="T"> 最后修改人唯一标识类型。 </typeparam>
    /// <seealso cref="ICreatedBy{T}" />
    /// <seealso cref="ICreatedTime" />
    /// <seealso cref="IModifiedTime" />
    public interface IModifiedBy<T> : IModifiedTime, ICreatedBy<T>, ICreatedTime
    {
        /// <summary> 最后修改人姓名。 </summary>
        /// <value> 设置或获取一个字符串，用于表示最后修改人姓名。 </value>
        string LatestModifier { get; set; }

        /// <summary> 最后修改人唯一标识。 </summary>
        /// <value> 设置或获取 <typeparamref name="T" /> 类型的对象实例或值，用于表示最后修改人唯一标识。 </value>
        T LatestModifierId { get; set; }
    }
}