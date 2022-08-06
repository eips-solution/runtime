/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Extensions
{
    /// <summary> 提供了创建哈希格式 ID 加密密钥相关的方法。 </summary>
    /// <seealso cref="IHashIdCryptographyKeyProvider" />
    public class HashIdCryptographyKeyProvider : IHashIdCryptographyKeyProvider
    {
        /// <summary> 哈希格式 ID 加密密钥。 </summary>
        /// <value> 获取一个字符串，用于表示哈希格式 ID 加密密钥。 </value>
        public virtual string Key => string.Empty;
    }
}