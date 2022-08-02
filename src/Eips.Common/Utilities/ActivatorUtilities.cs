/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System;

namespace Niacomsoft.Eips
{
    /// <summary> 提供了动态创建对象实例相关的辅助方法。 </summary>
    /// <seealso cref="Activator" />
    public class ActivatorUtilities
    {
        /// <summary> 用于初始化一个 <see cref="ActivatorUtilities" /> 类型的对象实例。 </summary>
        private ActivatorUtilities()
        {
        }

        /// <summary> 创建 <typeparamref name="T" /> 类型的对象实例。 </summary>
        /// <typeparam name="T"> 引用类型。 </typeparam>
        /// <param name="args"> 构造函数参数数组。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <exception cref="DynamicCreateObjectInstanceException">
        /// 当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
        /// </exception>
        public static T CreateInstance<T>(params object[] args) where T : class
        {
            try
            {
                return Activator.CreateInstance(typeof(T), args) as T;
            }
            catch (Exception activatorException)
            {
                throw new DynamicCreateObjectInstanceException(typeof(T), activatorException);
            }
        }
    }
}