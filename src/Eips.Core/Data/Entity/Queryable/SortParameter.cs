/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity.Queryable
{
    /// <summary> 提供了数据排序参数相关的方法。 </summary>
    /// <seealso cref="ISortParameter" />
    public class SortParameter : ISortParameter
    {
        /// <summary> 默认的排序字段。 </summary>
        public static readonly string[] DefaultSortingFields = new string[] { "latest_modified_time", "created_time" };

        /// <summary> 用于初始化一个 <see cref="SortParameter" /> 类型的对象实例。 </summary>
        public SortParameter() : this(null, null)
        {
        }

        /// <summary> 用于初始化一个 <see cref="SortParameter" /> 类型的对象实例。 </summary>
        /// <param name="mode"> 排序模式。 </param>
        public SortParameter(SortMode? mode) : this(mode, SortParameter.DefaultSortingFields)
        {
        }

        /// <summary> 用于初始化一个 <see cref="SortParameter" /> 类型的对象实例。 </summary>
        /// <param name="fields"> 排序字段。 </param>
        public SortParameter(string[] fields) : this(null, fields)
        {
        }

        /// <summary> 用于初始化一个 <see cref="SortParameter" /> 类型的对象实例。 </summary>
        /// <param name="mode"> 排序模式。 </param>
        /// <param name="fields"> 排序字段。 </param>
        public SortParameter(SortMode? mode, params string[] fields)
        {
            Mode = mode.HasValue ? mode.Value : SortMode.Default;
            Fields = fields;
        }

        /// <summary> 需要排序的字段。 </summary>
        /// <value> 设置或获取一个字符串数组，用于表示需要排序的字段。 </value>
        public virtual string[] Fields { get; set; }

        /// <summary> 排序方式。 </summary>
        /// <value> 设置或获取一个值，用于表示排序方式。 </value>
        /// <seealso cref="SortMode" />
        public virtual SortMode? Mode { get; set; }
    }
}