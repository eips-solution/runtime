/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips
{
    /// <summary> 提供了日期时间对比相关的方法。 </summary>
    /// <seealso cref="DateTime" />
    public partial struct DateTimeComparer
    {
        /// <summary> 用于初始化一个 <see cref="DateTimeComparer" /> 类型。 </summary>
        /// <param name="begin"> <see cref="DateTime" /> 类型的值。 </param>
        public DateTimeComparer(DateTime begin) : this(begin, DateTime.UtcNow)
        {
        }

        /// <summary> 用于初始化一个 <see cref="DateTimeComparer" /> 类型。 </summary>
        /// <param name="begin"> <see cref="DateTimeOffset" /> 类型的值。 </param>
        public DateTimeComparer(DateTimeOffset begin) : this(begin, DateTimeOffset.UtcNow)
        {
        }

        /// <summary> 用于初始化一个 <see cref="DateTimeComparer" /> 类型。 </summary>
        /// <param name="begin"> <see cref="DateTime" /> 类型的值。 </param>
        /// <param name="end"> <see cref="DateTime" /> 类型的值。 </param>
        public DateTimeComparer(DateTime begin, DateTime end)
        {
            Begin = begin;
            End = end;
        }

        /// <summary> 用于初始化一个 <see cref="DateTimeComparer" /> 类型。 </summary>
        /// <param name="begin"> <see cref="DateTimeOffset" /> 类型的值。 </param>
        /// <param name="end"> <see cref="DateTimeOffset" /> 类型的值。 </param>
        public DateTimeComparer(DateTimeOffset begin, DateTimeOffset end) : this(begin.UtcDateTime, end.UtcDateTime)
        {
        }

        /// <summary>
        /// 日期时间 <see cref="Begin" /> 是否在 <see cref="End" /> 之后。
        /// <para> 计算精度仅精确到“秒“。 </para>
        /// </summary>
        /// <value>
        /// 获取一个值，用于表示日期时间 <see cref="Begin" /> 是否在 <see cref="End" /> 之后。
        /// </value>
        /// <seealso cref="TimeSpan" />
        /// <seealso cref="TimeSpan.TotalSeconds" />
        /// <seealso cref="Intervals" />
        public bool After => ValueTypeComparer.Compare(Intervals.TotalSeconds, symbol: NumberComparisonSymbols.LessThanOrEqual);

        /// <summary>
        /// 日期时间 <see cref="Begin" /> 是否在 <see cref="End" /> 之前。
        /// <para> 计算精度仅精确到“秒“。 </para>
        /// </summary>
        /// <value>
        /// 获取一个值，用于表示日期时间 <see cref="Begin" /> 是否在 <see cref="End" /> 之后。
        /// </value>
        /// <seealso cref="TimeSpan" />
        /// <seealso cref="TimeSpan.TotalSeconds" />
        /// <seealso cref="Intervals" />
        public bool Before => ValueTypeComparer.Compare(Intervals.TotalSeconds, symbol: NumberComparisonSymbols.GreaterThanOrEqual);

        /// <summary> 用于对比的起始日期时间。 </summary>
        /// <value> 获取一个值，用于表示用于对比的起始日期时间。 </value>
        public DateTime Begin { get; private set; }

        /// <summary> 用于对比的截止日期时间。 </summary>
        /// <value> 获取一个值，用于表示用于对比的截止日期时间。 </value>
        public DateTime End { get; private set; }

        /// <summary> <see cref="End" /> 和 <see cref="Begin" /> 的时间间隔。 </summary>
        /// <value> 获取一个值，用于表示 <see cref="End" /> 和 <see cref="Begin" /> 的时间间隔。 </value>
        /// <seealso cref="TimeSpan" />
        public TimeSpan Intervals => End - Begin;

        /// <summary> <see cref="Begin" /> 和 <see cref="End" /> 是否同年同月同日。 </summary>
        /// <value>
        /// 获取一个值，用于表示 <see cref="Begin" /> 和 <see cref="End" /> 是否同年同月同日。
        /// </value>
        public bool IsSameDay => IsSameMonth & ValueTypeComparer.Compare(Begin.Day, End.Day);

        /// <summary> <see cref="Begin" /> 和 <see cref="End" /> 是否同年同月。 </summary>
        /// <value>
        /// 获取一个值，用于表示 <see cref="Begin" /> 和 <see cref="End" /> 是否同年同月。
        /// </value>
        public bool IsSameMonth => IsSameYear && ValueTypeComparer.Compare(Begin.Month, End.Month);

        /// <summary> <see cref="Begin" /> 和 <see cref="End" /> 是否同年。 </summary>
        /// <value>
        /// 获取一个值，用于表示 <see cref="Begin" /> 和 <see cref="End" /> 是否同年。
        /// </value>
        public bool IsSameYear => ValueTypeComparer.Compare(Begin.Year, End.Year);
    }
}