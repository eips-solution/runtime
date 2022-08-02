/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips
{
    /// <summary> 提供了引用类型相等对比相关的方法。 </summary>
    public class ReferenceTypeEqualityComparer
    {
        /// <summary>
        /// 用于初始化一个 <see cref="ReferenceTypeEqualityComparer" /> 类型的对象实例。
        /// </summary>
        private ReferenceTypeEqualityComparer()
        {
        }

        /// <summary> 用于校验 <paramref name="obj" /> 是否等于 <c> null </c>。 </summary>
        /// <param name="obj"> 需要校验的对象实例。 </param>
        /// <returns>
        /// 当 <paramref name="obj" /> 等于 <c> null </c> 时，则返回 <c> true </c>；否则返回
        /// <c> false </c>。
        /// </returns>
        public static bool None(object obj) => obj is null;

        /// <summary> 用于校验 <paramref name="obj" /> 是否不等于 <c> null </c>。 </summary>
        /// <param name="obj"> 需要校验的对象实例。 </param>
        /// <returns>
        /// 当 <paramref name="obj" /> 不等于 <c> null </c> 时，则返回 <c> true </c>；否则返回
        /// <c> false </c>。
        /// </returns>
        /// <seealso cref="ReferenceTypeEqualityComparer.None(object)" />
        public static bool NotNone(object obj) => !None(obj);
    }
}