/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Extensions
{
    /// <summary> 定义了创建哈希格式 ID 加密密钥的接口。 </summary>
    public interface IHashIdCryptographyKeyProvider
    {
        /// <summary> 哈希格式 ID 加密密钥。 </summary>
        /// <value> 获取一个字符串，用于表示哈希格式 ID 加密密钥。 </value>
        string Key { get; }
    }
}