/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Fields
{
    /// <summary> 定义了标记是否移除的接口。 </summary>
    /// <typeparam name="T"> 标记是否移除的类型。 </typeparam>
    public interface IRemoved<T> where T : struct
    {
        /// <summary> 是否允许移除后还原。 </summary>
        /// <value> 设置或获取一个值，用于表示是否允许移除后还原。 </value>
        T AllowRestore { get; set; }

        /// <summary> 是否已经移除。 </summary>
        /// <value> 设置或获取一个值，用于表示是否已经移除。 </value>
        T HasRemoved { get; set; }

        /// <summary> 状态是否正常。 </summary>
        /// <value> 获取一个值，用于表示状态是否正常。 </value>
        T Normal { get; set; }

        /// <summary> 是否已经物理删除。 </summary>
        /// <value> 获取一个值，用于表示是否已经物理删除。 </value>
        bool PhysicalDeleted { get; }
    }
}