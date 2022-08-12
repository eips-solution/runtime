/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Runtime.Serializations
{
    /// <summary> 提供了 JSON 序列化属性名称。 </summary>
    public class JsonSerializerProperties
    {
        /// <summary> 用于初始化一个 <see cref="JsonSerializerProperties" /> 类型的对象实例。 </summary>
        private JsonSerializerProperties()
        {
        }

        /// <summary> 访问令牌。 </summary>
        public const string AccessToken = "access_token";

        /// <summary> 别名。 </summary>
        public const string Alias = "alias";

        /// <summary> 自动的 ID。 </summary>
        public const string AutoId = "__aid__";

        /// <summary> 是否已经激活的。 </summary>
        public const string Available = "available";

        /// <summary> 是否为系统内置的。 </summary>
        public const string BuiltIn = "buildin";

        /// <summary> 创建时间。 </summary>
        public const string CreatedTime = "createdTime";

        /// <summary> 创建时间描述。 </summary>
        public const string CreatedTimeDescription = "createdAt";

        /// <summary> 创建人姓名。 </summary>
        public const string Creator = "createdBy";

        /// <summary> 是否默认选项。 </summary>
        public const string DefaultOptions = "default";

        /// <summary> 是否可用。 </summary>
        public const string Enable = "enabled";

        /// <summary> 是否冻结。 </summary>
        public const string Frozen = "frozen";

        /// <summary> 性别。 </summary>
        public const string Gender = "gender";

        /// <summary> 标识。 </summary>
        public const string Id = "__id__";

        /// <summary> 是否被锁定。 </summary>
        public const string Locked = "locked";

        /// <summary> 最后修改时间。 </summary>
        public const string ModifiedTime = "modifiedTime";

        /// <summary> 最后修改时间描述。 </summary>
        public const string ModifiedTimeDescription = "modifiedAt";

        /// <summary> 最后修改人姓名。 </summary>
        public const string Modifier = "modifiedBy";

        /// <summary> 姓名。 </summary>
        public const string Name = "name";

        /// <summary> 昵称。 </summary>
        public const string NickName = "nickName";

        /// <summary> 备注信息。 </summary>
        public const string Notes = "notes";

        /// <summary> 开放标识。 </summary>
        public const string OpenId = "__oid__";

        /// <summary> 可供分页的元素集合。 </summary>
        public const string PagedElements = "rows";

        /// <summary> 是否被物理删除。 </summary>
        public const string PhysicalDeleted = "deleted";

        /// <summary> 是否只读。 </summary>
        public const string ReadOnly = "readonly";

        /// <summary> 刷新后的访问令牌。 </summary>
        public const string RefreshToken = "refresh_token";

        /// <summary> 是否被逻辑删除。 </summary>
        public const string Removed = "removed";

        /// <summary> 电子签名。 </summary>
        public const string Signature = "sign";

        /// <summary> 分页后的总行数。 </summary>
        public const string TotalRowsNumber = "total";

        /// <summary> 唯一标识。 </summary>
        public const string UniqueId = "__uid__";

        /// <summary> 版本号数字。 </summary>
        public const string VersionNumber = "version";

        /// <summary> 是否虚拟的。 </summary>
        public const string Virtual = "virtual";

        /// <summary> 是否可见。 </summary>
        public const string Visible = "visible";
    }
}