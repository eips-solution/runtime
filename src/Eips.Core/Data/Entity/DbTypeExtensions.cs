/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity
{
    /// <summary>
    /// 为 C# 类型提供的扩展方法。
    /// <para> 提供了 C# 类型和数据库类型值相互转换的方法。 </para>
    /// </summary>
    public static class DbTypeExtensions
    {
        /// <summary>
        /// 将数据库中的可为空的 <see cref="int" /> 类型的值转换成 <see cref="bool" /> 类型的值。
        /// </summary>
        /// <param name="dbValue"> 存储在数据库中可为空的 <see cref="int" /> 类型的值。 </param>
        /// <returns>
        /// 可为空的 <see cref="bool" /> 类型的值。
        /// <para>
        /// 当 <paramref name="dbValue" />.HasValue 等于 <c> false </c> 时，将返回 <c>
        /// null </c>。
        /// </para>
        /// <para>
        /// 当 <paramref name="dbValue" /> 等于 <c> 1 </c> 时，则返回 <c> true </c>；否则返回
        /// <c> false </c>。
        /// </para>
        /// </returns>
        public static bool? ToBoolean(this int? dbValue)
        {
            if (dbValue.HasValue) return ValueTypeComparer.Compare(dbValue.Value, Defaults.TrueInt32);
            return null;
        }

        /// <summary>
        /// 将数据库中的可为空的 <see cref="int" /> 类型的值转换成 <see cref="bool" /> 类型的值。
        /// </summary>
        /// <param name="dbValue"> 存储在数据库中可为空的 <see cref="int" /> 类型的值。 </param>
        /// <param name="ifNull">
        /// 当 <paramref name="ifNull" /> 等于 <c> null </c> 时的返回值。
        /// </param>
        /// <returns>
        /// 等效的 <see cref="bool" /> 类型的值。
        /// <para>
        /// 当 <paramref name="dbValue" />.HasValue 等于 <c> false </c> 时，将返回 <paramref name="ifNull" />。
        /// </para>
        /// <para>
        /// 当 <paramref name="dbValue" /> 等于 <c> 1 </c> 时，则返回 <c> true </c>；否则返回
        /// <c> false </c>。
        /// </para>
        /// </returns>
        public static bool ToBoolean(this int? dbValue, bool ifNull = true)
        {
            var value = dbValue.ToBoolean();
            return value.HasValue ? value.Value : ifNull;
        }

        /// <summary>
        /// 将数据库中的 <see cref="int" /> 类型的值转换成 <see cref="bool" /> 类型的值。
        /// </summary>
        /// <param name="dbValue"> 存储在数据库中 <see cref="int" /> 类型的值。 </param>
        /// <returns>
        /// <see cref="bool" /> 类型的值。
        /// <para>
        /// 当 <paramref name="dbValue" /> 等于 <c> 1 </c> 时，则返回 <c> true </c>；否则返回
        /// <c> false </c>。
        /// </para>
        /// </returns>
        public static bool ToBoolean(this int dbValue) => ValueTypeComparer.Compare(dbValue, Defaults.TrueInt32);

        /// <summary>
        /// 将可为空的 <see cref="bool" /> 类型的值转换成等效的可为空的 <see cref="int" /> 类型的值。
        /// </summary>
        /// <param name="value"> 可为空的 <see cref="bool" /> 类型的值。 </param>
        /// <returns>
        /// 可为空的 <see cref="int" /> 类型的值。
        /// <para>
        /// 当 <paramref name="value" />.HasValue 等于 <c> false </c> 时，返回 <c> null </c>。
        /// </para>
        /// <para>
        /// 当 <paramref name="value" /> 等于 <c> true </c> 时，将返回 <c> 1 </c>；否则返回
        /// <c> 0 </c>。
        /// </para>
        /// </returns>
        public static int? ToInt(this bool? value)
        {
            if (value.HasValue) return ToInt(value.Value);
            return null;
        }

        /// <summary>
        /// 将 <see cref="bool" /> 类型的值转换成等效的 <see cref="int" /> 类型的值。
        /// </summary>
        /// <param name="value"> <see cref="bool" /> 类型的值。 </param>
        /// <returns>
        /// <see cref="int" /> 类型的值。
        /// <para>
        /// 当 <paramref name="value" /> 等于 <c> true </c> 时，将返回 <c> 1 </c>；否则返回
        /// <c> 0 </c>。
        /// </para>
        /// </returns>
        public static int ToInt(this bool value) => ToInt(value, Defaults.TrueInt32, Defaults.FalseInt32);

        /// <summary>
        /// 将 <see cref="bool" /> 类型的值转换成等效的 <see cref="int" /> 类型的值。
        /// </summary>
        /// <param name="value"> <see cref="bool" /> 类型的值。 </param>
        /// <param name="ifTrue"> <c> true </c> 等效的 <see cref="int" /> 类型的值。 </param>
        /// <param name="ifFalse"> <c> false </c> 等效的 <see cref="int" /> 类型的值。 </param>
        /// <returns>
        /// <see cref="int" /> 类型的值。
        /// <para>
        /// 当 <paramref name="value" /> 等于 <c> true </c> 时，将返回
        /// <paramref name="ifTrue" />；否则返回 <paramref name="ifFalse" />。
        /// </para>
        /// </returns>
        /// <seealso cref="Defaults" />
        public static int ToInt(this bool value, int ifTrue = Defaults.TrueInt32, int ifFalse = Defaults.FalseInt32)
            => value ? ifTrue : ifFalse;
    }
}