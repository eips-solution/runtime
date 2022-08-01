/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using Niacomsoft.Eips.Globalization.Resources;
using System;
using System.Resources;

namespace Niacomsoft.Eips.Globalization
{
    /// <summary> 提供了字符串资源相关的方法。 </summary>
    public class SR
    {
        private static readonly ResourceManager _resourceMgr = Strings.ResourceManager;

        /// <summary> 用于初始化一个 <see cref="SR" /> 类型的对象实例。 </summary>
        private SR()
        {
        }

        /// <summary> 获取指定名称的资源字符串。 </summary>
        /// <param name="resName"> 资源名称。 </param>
        /// <returns> 资源字符串。 </returns>
        /// <seealso cref="ResourceManager.GetString(string)" />
        /// <exception cref="ArgumentException">
        /// 当使用 <see cref="string.IsNullOrWhiteSpace(string)" /> 方法验证
        /// <paramref name="resName" /> 返回 <c> true </c> 时，将引发此类型的异常。
        /// </exception>
        private static string InternalGetString(string resName)
        {
            InvalidResourceName(resName);
            return _resourceMgr.GetString(resName);
        }

        /// <summary>
        /// 当使用 <see cref="string.IsNullOrWhiteSpace(string)" /> 验证
        /// <paramref name="resName" /> 返回 <c> true </c> 时，将引发一个
        /// <see cref="ArgumentException" /> 类型的异常。
        /// </summary>
        /// <param name="resName"> 需要校验的资源名称。 </param>
        private static void InvalidResourceName(string resName)
        {
            if (string.IsNullOrWhiteSpace(resName))
                throw new ArgumentException(
                                    string.Format(
                                        Strings.ArgumentException_empty_or_whitespace,
                                        nameof(resName)),
                                    nameof(resName));
        }

        /// <summary>
        /// 获取指定名称的资源字符串，并调用 <see cref="string.Format(string, object[])" /> 方法进行格式化。
        /// </summary>
        /// <param name="resourceName"> 资源名称。 </param>
        /// <param name="args"> 格式化参数数组。 </param>
        /// <returns> 格式化后的资源字符串。 </returns>
        /// <seealso cref="string.Format(string, object[])"/>
        public static string Format(string resourceName, params object[] args) 
            => string.Format(InternalGetString(resourceName), args);

        /// <summary> 获取指定名称的资源字符串。 </summary>
        /// <param name="resourceName"> 资源名称。 </param>
        /// <returns> 资源字符串。 </returns>
        public static string GetString(string resourceName) 
            => InternalGetString(resourceName);
    }
}