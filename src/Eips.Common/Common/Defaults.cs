/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Text;

namespace Niacomsoft.Eips
{
    /// <summary> 提供了企业私有 SaaS 服务相关的默认值。 </summary>
    public class Defaults
    {
        /// <summary> 默认数据库连接超时时间（单位：秒）。 </summary>
        public const int DefaultDbConnectTimeout = 0x3C;

        /// <summary> 默认的诊断器类别。 </summary>
        public const string DefaultDiagnosticCategory = "EIPS";

        /// <summary> 默认密码字母表。 </summary>
        public const string DefaultPasswordAlphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_-!@#$%^&*=+";

        /// <summary> 默认每页分页大小。 </summary>
        public const int DefaultPerPaginationSize = 0x14;

        /// <summary> 等效于 <c> false </c> 的 <see cref="int" /> 类型的值。 </summary>
        public const int FalseInt32 = 0;

        /// <summary> 最小的分页索引数字。 </summary>
        public const int MinimumPaginationIndex = 0;

        /// <summary> 等效于 <c> true </c> 的 <see cref="int" /> 类型的值。 </summary>
        public const int TrueInt32 = 1;

        /// <summary>
        /// 默认的编码程序。
        /// <para> <see cref="Encoding" /> 类型的对象实例。 </para>
        /// </summary>
        /// <seealso cref="Encoding" />
        /// <seealso cref="UTF8Encoding" />
        public static readonly Encoding DefaultEncoding = Encoding.UTF8;

        /// <summary> 用于初始化一个 <see cref="Defaults" /> 类型的对象实例。 </summary>
        private Defaults()
        {
        }
    }
}