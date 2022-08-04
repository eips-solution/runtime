﻿/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Text;

namespace Niacomsoft.Eips
{
    /// <summary> 提供了企业私有 SaaS 服务相关的默认值。 </summary>
    public class Defaults
    {
        /// <summary> 用于初始化一个 <see cref="Defaults" /> 类型的对象实例。 </summary>
        private Defaults()
        {
        }

        /// <summary> 默认的诊断器类别。 </summary>
        public const string DefaultDiagnosticCategory = "EIPS";

        /// <summary>
        /// 默认的编码程序。
        /// <para> <see cref="Encoding" /> 类型的对象实例。 </para>
        /// </summary>
        /// <seealso cref="Encoding" />
        /// <seealso cref="UTF8Encoding" />
        public static readonly Encoding DefaultEncoding = Encoding.UTF8;
    }
}