/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Runtime.Serializations
{
    /// <summary> 提供了 XML 序列化属性名称。 </summary>
    public class XmlSerializerProperties
    {
        /// <summary> 用于初始化一个 <see cref="XmlSerializerProperties" /> 类型的对象实例。 </summary>
        private XmlSerializerProperties()
        {
        }

        /// <summary> 访问令牌。 </summary>
        public const string AccessToken = "AccessToken";

        /// <summary> 别名。 </summary>
        public const string Alias = "Alias";

        /// <summary> 自动的 ID。 </summary>
        public const string AutoId = "AutoId";

        /// <summary> 是否已经激活的。 </summary>
        public const string Available = "Available";

        /// <summary> 是否为系统内置的。 </summary>
        public const string BuiltIn = "BuildIn";

        /// <summary> 创建时间。 </summary>
        public const string CreatedTime = "CreatedTime";

        /// <summary> 创建时间描述。 </summary>
        public const string CreatedTimeDescription = "CreatedAt";

        /// <summary> 创建人姓名。 </summary>
        public const string Creator = "CreatedBy";

        /// <summary> XML 序列化默认命名空间。 </summary>
        public const string DefaultNamespace = "urn:dotnet.niacomsoft.eips";

        /// <summary> XML 序列化默认命名空间前缀。 </summary>
        public const string DefaultNamespacePrefix = "eips";

        /// <summary> 是否默认选项。 </summary>
        public const string DefaultOptions = "DefaultOptions";

        /// <summary> 是否可用。 </summary>
        public const string Enable = "Enabled";

        /// <summary> 是否冻结。 </summary>
        public const string Frozen = "Frozen";

        /// <summary> 性别。 </summary>
        public const string Gender = "Gender";

        /// <summary> 标识。 </summary>
        public const string Id = "Id";

        /// <summary> 是否被锁定。 </summary>
        public const string Locked = "Locked";

        /// <summary> 最后修改时间。 </summary>
        public const string ModifiedTime = "ModifiedTime";

        /// <summary> 最后修改时间描述。 </summary>
        public const string ModifiedTimeDescription = "ModifiedAt";

        /// <summary> 最后修改人姓名。 </summary>
        public const string Modifier = "ModifiedBy";

        /// <summary> 姓名。 </summary>
        public const string Name = "Name";

        /// <summary> 昵称。 </summary>
        public const string NickName = "NickName";

        /// <summary> 备注信息。 </summary>
        public const string Notes = "Notes";

        /// <summary> 开放标识。 </summary>
        public const string OpenId = "OpenId";

        /// <summary> 可供分页的元素集合。 </summary>
        public const string PagedElements = "Rows";

        /// <summary> 是否被物理删除。 </summary>
        public const string PhysicalDeleted = "Deleted";

        /// <summary> 是否只读。 </summary>
        public const string ReadOnly = "ReadOnly";

        /// <summary> 刷新后的访问令牌。 </summary>
        public const string RefreshToken = "RefreshToken";

        /// <summary> 是否被逻辑删除。 </summary>
        public const string Removed = "Removed";

        /// <summary> 电子签名。 </summary>
        public const string Signature = "Signature";

        /// <summary> 分页后的总行数。 </summary>
        public const string TotalRowsNumber = "Total";

        /// <summary> 唯一标识。 </summary>
        public const string UniqueId = "UniqueId";

        /// <summary> 版本号数字。 </summary>
        public const string VersionNumber = "Version";

        /// <summary> 是否虚拟的。 </summary>
        public const string Virtual = "Virtual";

        /// <summary> 是否可见。 </summary>
        public const string Visible = "Visible";
    }
}