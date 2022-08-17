/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Reflection;
using System;
using System.ComponentModel;

namespace Niacomsoft.Eips.Data
{
    /// <summary> 为 <see cref="DbProvider" /> 类型提供的扩展方法。 </summary>
    public static class DbProviderExtensions
    {
        /// <summary> 获取数据库访问程序名称。 </summary>
        /// <param name="provider"> <see cref="DbProvider" /> 类型的值。 </param>
        /// <returns> 数据库访问程序名称。 </returns>
        public static string GetProviderName(this DbProvider provider)
        {
            var fieldName = Enum.GetName(typeof(DbProvider), provider);
            var fieldInfo = typeof(DbProvider).GetField(fieldName);
            return MemberAttributeHelper.Instance.GetCustomAttribute<DescriptionAttribute>(fieldInfo).Description;
        }
    }
}