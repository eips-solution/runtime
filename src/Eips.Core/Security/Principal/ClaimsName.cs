/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Security.Principal
{
    /// <summary> 提供了内置的身份信息点名称。 </summary>
    public class ClaimsName
    {
        /// <summary> 用于初始化一个 <see cref="ClaimsName" /> 类型的对象实例。 </summary>
        private ClaimsName()
        {
        }

        /// <summary> 用户真实姓名。 </summary>
        public const string Name = "e-rn";

        /// <summary> 用户昵称。 </summary>
        public const string NickName = "e-nn";

        /// <summary> 用户在子系统中的开放标识。 </summary>
        public const string OpenId = "e-oid";

        /// <summary> 用户在 EIPS 中的唯一标识。 </summary>
        public const string UniqueId = "e-uid";

        /// <summary> 登录用户名。 </summary>
        public const string UserName = "e-un";
    }
}