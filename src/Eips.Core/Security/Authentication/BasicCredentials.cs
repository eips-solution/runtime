/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips.Security.Authentication
{
    /// <summary> 提供了基于用户名、密码的基础身份认证凭据相关的方法。 </summary>
    [Serializable]
    public class BasicCredentials
    {
        /// <summary> 已经经过加密的登录密码。 </summary>
        /// <value> 设置或获取一个字符串，用于表示已经经过加密的登录密码。 </value>
        public virtual string Password { get; set; }

        /// <summary> 用户名。 </summary>
        /// <value> 设置或获取一个字符串，用于表示用户名。 </value>
        public virtual string UserName { get; set; }
    }
}