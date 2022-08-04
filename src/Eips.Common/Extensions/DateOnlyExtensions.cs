/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips
{
#if NET6_0_OR_GREATER
    /// <summary> 为 <see cref="DateOnly" /> 类型提供的扩展方法。 </summary>
    public static class DateOnlyExtensions
    {
        /// <summary>
        /// 将 <see cref="DateOnly" /> 类型的值 <paramref name="value" /> 转换成
        /// <see cref="DateTime" /> 类型的值。
        /// </summary>
        /// <param name="value"> <see cref="DateTime" /> 类型的值。 </param>
        /// <returns> <see cref="DateTime" /> 类型的值。 </returns>
        /// <seealso cref="TimeOnly" />
        /// <seealso cref="TimeOnly.MinValue" />
        /// <seealso cref="DateTime" />
        public static DateTime ToDateTime(this DateOnly value) => value.ToDateTime(TimeOnly.MinValue, DateTimeKind.Utc);
    }
#endif
}