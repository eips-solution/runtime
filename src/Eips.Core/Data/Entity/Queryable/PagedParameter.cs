/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Diagnostics;
using System.Diagnostics;

namespace Niacomsoft.Eips.Data.Entity.Queryable
{
    /// <summary> 提供了分页查询参数相关的方法。 </summary>
    /// <seealso cref="IPagedParameter" />
    public class PagedParameter : IPagedParameter
    {
        /// <summary> 用于初始化一个 <see cref="PagedParameter" /> 类型的对象实例。 </summary>
        public PagedParameter() : this(Defaults.DefaultPerPaginationSize)
        {
        }

        /// <summary> 用于初始化一个 <see cref="PagedParameter" /> 类型的对象实例。 </summary>
        /// <param name="size"> 每页的数据行数。 </param>
        public PagedParameter(int size) : this(Defaults.MinimumPaginationIndex, size)
        {
        }

        /// <summary> 用于初始化一个 <see cref="PagedParameter" /> 类型的对象实例。 </summary>
        /// <param name="index"> 当前页索引数字。 </param>
        /// <param name="size"> 每页的数据行数。 </param>
        public PagedParameter(int index, int size)
        {
            if (ValueTypeComparer.Compare(index, symbol: NumberComparisonSymbols.LessThan))
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget<PagedParameter>()
                                                             .WithMethod("Constructor")
                                                             .WithMessage($"页索引数字 “{nameof(index)} ({index})” 小于 0，将使用 “{nameof(Defaults)}.{nameof(Defaults.MinimumPaginationIndex)}” 替换。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);
                index = Defaults.MinimumPaginationIndex;
            }

            CurrentIndex = index;

            if (ValueTypeComparer.Compare(size, symbol: NumberComparisonSymbols.LessThan))
            {
                Debug.WriteLine(new TraceInformationBuilder().WithTarget<PagedParameter>()
                                                             .WithMethod("Constructor")
                                                             .WithMessage($"每页数据行数 “{nameof(size)} ({size})” 小于 0，将使用 “{nameof(Defaults)}.{nameof(Defaults.DefaultPerPaginationSize)}” 替换。")
                                                             .Build(),
                                Defaults.DefaultDiagnosticCategory);

                size = Defaults.DefaultPerPaginationSize;
            }

            PerPageSize = size;
        }

        /// <summary> 需要查询的当前页索引数字。 </summary>
        /// <value> 设置或获取一个值，用于表示需要查询的当前页索引数字。 </value>
        public virtual int CurrentIndex { get; set; }

        /// <summary> 每页数据行数。 </summary>
        /// <value> 设置或获取一个值，用于表示每页数据行数。 </value>
        public virtual int PerPageSize { get; set; }
    }
}