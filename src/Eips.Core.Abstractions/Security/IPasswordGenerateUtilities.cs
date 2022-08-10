/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Security
{
    /// <summary> 定义了生成密码的接口。 </summary>
    public interface IPasswordGenerateUtilities
    {
        /// <summary> 生成密码的字母表。 </summary>
        /// <value> 设置或获取一个字符串，用于表示生成密码的字母表。 </value>
        string Alphabet { get; set; }

        /// <summary> 创建新的密码 </summary>
        /// <param name="size"> 密码长度。 </param>
        /// <returns> 新的随机密码。 </returns>
        string CreateNew(int size = 8);
    }
}