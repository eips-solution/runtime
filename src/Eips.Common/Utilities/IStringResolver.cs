/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips
{
    /// <summary> 定义了解释字符串的接口。 </summary>
    public interface IStringResolver
    {
        /// <summary> 解释字符串。 </summary>
        /// <param name="s"> 解释前的原始字符串。 </param>
        /// <param name="args"> 附加参数。 </param>
        /// <returns> 字符串。 </returns>
        string Resolve(string s, params object[] args);
    }
}