/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Globalization;
using Niacomsoft.Eips.Reflection;
using System;
using System.ComponentModel;

namespace Niacomsoft.Eips.Security.Authentication
{
    /// <summary> 为 <see cref="AuthenticationFailureReason" /> 类型提供的扩展方法。 </summary>
    public static class AuthenticationFailureReasonExtensions
    {
        /// <summary> 获取 <paramref name="reason" /> 等效的描述内容。 </summary>
        /// <param name="reason">
        /// <see cref="AuthenticationFailureReason" /> 类型的值。
        /// </param>
        /// <returns>
        /// 身份认证失败原因。
        /// <para> <see cref="AuthenticationFailureReason" /> 类型的值等效的描述内容。 </para>
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// 当调用 <see cref="Type.GetField(string)" /> 方法时，可能引发此类型的异常。
        /// </exception>
        public static string GetDescription(this AuthenticationFailureReason reason)
        {
            var reasonType = typeof(AuthenticationFailureReason);
            var fieldName = Enum.GetName(reasonType, reason);
            var field = reasonType.GetField(fieldName);
            var descriptionAttr = MemberAttributeHelper.Instance.GetCustomAttribute<DescriptionAttribute>(field);
            return SR.GetString(descriptionAttr.Description);
        }
    }
}