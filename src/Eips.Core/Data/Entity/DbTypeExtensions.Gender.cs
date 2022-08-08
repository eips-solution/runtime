/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Collections.Generic;
using System.Linq;

namespace Niacomsoft.Eips.Data.Entity
{
    public static partial class DbTypeExtensions
    {
        private static readonly IDictionary<Gender, int> sr_genderMapDictionary = new Dictionary<Gender, int>()
        {
            {Gender.Unknown, -1},
            {Gender.Male,1},
            {Gender.Female,2}
        };

        /// <summary>
        /// 将可为空的 <see cref="int" /> 类型的值转换成等效的 <see cref="Gender" /> 类型的值。
        /// </summary>
        /// <param name="value"> 可为空的 <see cref="int" /> 类型的值。 </param>
        /// <returns>
        /// 等效的 <see cref="Gender" /> 类型的值。
        /// <para> <c> null </c> 等效于 <see cref="Gender.NotSupport" />； </para>
        /// <para> -1 等效于 <see cref="Gender.Unknown" />； </para>
        /// <para> 1 等效于 <see cref="Gender.Male" />； </para>
        /// <para> 2 等效于 <see cref="Gender.Female" />。 </para>
        /// </returns>
        public static Gender ToGender(this int? value)
        {
            if (value.HasValue)
            {
                var result = sr_genderMapDictionary.SingleOrDefault(item => item.Value == value.Value);
                if (!ReferenceTypeEqualityComparer.None(result))
                    return result.Key;
            }
            return Gender.NotSupport;
        }

        /// <summary>
        /// 将 <see cref="Gender" /> 类型的值转换成等效的可为空的 <see cref="int" /> 类型的值。。
        /// </summary>
        /// <param name="value"> <see cref="Gender" /> 类型的值。 </param>
        /// <returns>
        /// 等效的可为空的 <see cref="int" /> 类型的值。
        /// <para> <see cref="Gender.NotSupport" /> 等效于 <c> null </c>； </para>
        /// <para> <see cref="Gender.Unknown" /> 等效于 -1； </para>
        /// <para> <see cref="Gender.Male" /> 等效于 1； </para>
        /// <para> <see cref="Gender.Female" /> 等效于 2。 </para>
        /// </returns>
        public static int? ToInt(this Gender value)
        {
            if (value == Gender.NotSupport) return null;
            return sr_genderMapDictionary[value];
        }
    }
}