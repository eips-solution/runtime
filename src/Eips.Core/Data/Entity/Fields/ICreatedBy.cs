/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了标识数据实体创建人信息的接口。 </summary>
    /// <typeparam name="T"> 创建人唯一标识类型。 </typeparam>
    /// <seealso cref="ICreatedTime" />
    public interface ICreatedBy<T> : ICreatedTime
    {
        /// <summary> 创建人姓名。 </summary>
        /// <value> 设置或获取一个字符串，用于表示创建人姓名。 </value>
        string Creator { get; set; }

        /// <summary> 创建人唯一标识。 </summary>
        /// <value> 设置或获取 <typeparamref name="T" /> 类型的对象实例或值，用于表示创建人唯一标识。 </value>
        T CreatorId { get; set; }
    }
}