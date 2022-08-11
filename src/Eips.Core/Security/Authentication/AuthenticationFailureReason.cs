/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.ComponentModel;

namespace Niacomsoft.Eips.Security.Authentication
{
    /// <summary> 定义了身份认证失败原因枚举类型。 </summary>
    public enum AuthenticationFailureReason
    {
        /// <summary> 用户不存在。 </summary>
        [Description("AuthenticationFailureReason_user_not_exists")]
        UserNotExists = 1,

        /// <summary> 错误的登录密码。 </summary>
        [Description("AuthenticationFailureReason_wrong_password")]
        IncorrectLoginPassword = 2
    }
}