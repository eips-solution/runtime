/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips
{
#if NET6_0_OR_GREATER
    public partial struct DateTimeComparer
    {
        /// <summary> 用于初始化一个 <see cref="DateTimeComparer" /> 类型。 </summary>
        /// <param name="begin"> <see cref="DateOnly" /> 类型的值。 </param>
        /// <param name="end"> <see cref="DateOnly" /> 类型的值。 </param>
        public DateTimeComparer(DateOnly begin, DateOnly end) : this(begin.ToDateTime(), end.ToDateTime())
        {
        }

        /// <summary> 用于初始化一个 <see cref="DateTimeComparer" /> 类型。 </summary>
        /// <param name="begin"> <see cref="DateOnly" /> 类型的值。 </param>
        public DateTimeComparer(DateOnly begin) : this(begin.ToDateTime())
        {
        }
    }
#endif
}