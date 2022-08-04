/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Globalization;
using System;

namespace Niacomsoft.Eips
{
    /// <summary> 提供了描述日期时间相关的方法。 </summary>
    public class DateTimeDescriptor
    {
        /// <summary> 用于初始化一个 <see cref="DateTimeDescriptor" /> 类型的对象实例。 </summary>
        private DateTimeDescriptor()
        {
        }

        /// <summary>
        /// 获取日期时间的描述。
        /// <para>
        /// 此方法将使用 <paramref name="dateTime" /> 与 <see cref="DateTime.UtcNow" /> 进行对比。
        /// </para>
        /// </summary>
        /// <param name="dateTime"> 可为空的 <see cref="DateTime" /> 类型的值。 </param>
        /// <returns>
        /// 日期时间的描述信息。
        /// <para>
        /// 当 <paramref name="dateTime" />.HasValue 等于 <c> false </c> 时，将返回 <c>
        /// null </c>。
        /// </para>
        /// </returns>
        public static string GetDescription(DateTime? dateTime)
        {
            if (!dateTime.HasValue) return null;
            var comparer = new DateTimeComparer(dateTime.Value, DateTime.UtcNow);
            if (comparer.After)
                return comparer.Begin.ToString(SR.GetString(comparer.IsSameYear
                    ? "DateTime_formatter_same_year"
                    : "DateTime_formatter"));
            else if (ValueTypeComparer.Compare(comparer.Intervals.TotalSeconds,
                                               10.0,
                                               NumberComparisonSymbols.LessThanOrEqual))
                return SR.GetString("DateTime_formatter_just_now");
            else if (ValueTypeComparer.Compare(comparer.Intervals.TotalSeconds,
                                               60.0,
                                               NumberComparisonSymbols.LessThanOrEqual))
                return SR.GetString("DateTime_formatter_a_minute_ago");
            else if (ValueTypeComparer.Compare(comparer.Intervals.TotalMinutes,
                                               60.0,
                                               NumberComparisonSymbols.LessThanOrEqual))
                return SR.Format("DateTime_formatter_a_few_minutes_ago", (int)comparer.Intervals.TotalMinutes);
            else if (ValueTypeComparer.Compare(comparer.Intervals.TotalHours,
                                               24.0,
                                               NumberComparisonSymbols.LessThanOrEqual))
                return SR.Format("DateTime_formatter_a_few_hours_ago", (int)comparer.Intervals.TotalHours);
            else if (ValueTypeComparer.Compare(comparer.Intervals.TotalDays,
                                               180.0,
                                               NumberComparisonSymbols.LessThanOrEqual))
                return SR.Format("DateTime_formatter_a_few_days_ago", (int)comparer.Intervals.TotalDays);
            else
                return comparer.Begin.ToString(SR.GetString(comparer.IsSameYear
                    ? "DateTime_formatter_same_year"
                    : "DateTime_formatter"));
        }

        /// <summary> 获取日期时间的描述。 </summary>
        /// <param name="dateTime"> 可为空的 <see cref="DateTimeOffset" /> 类型的值。 </param>
        /// <returns>
        /// 日期时间的描述信息。
        /// <para>
        /// 当 <paramref name="dateTime" />.HasValue 等于 <c> false </c> 时，将返回 <c>
        /// null </c>。
        /// </para>
        /// </returns>
        public static string GetDescription(DateTimeOffset? dateTime) => GetDescription(dateTime?.UtcDateTime);

#if NET6_0_OR_GREATER
        /// <summary> 获取日期的描述。 </summary>
        /// <param name="date"> 可为空的 <see cref="DateOnly" /> 类型的值。 </param>
        /// <returns>
        /// 日期时间的描述信息。
        /// <para>
        /// 当 <paramref name="date" />.HasValue 等于 <c> false </c> 时，将返回 <c> null </c>。
        /// </para>
        /// </returns>
        public static string GetDescription(DateOnly? date) => GetDescription(date?.ToDateTime());
#endif
    }
}