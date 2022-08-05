/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips
{
    /// <summary> 定义了生成 ID 的方法接口。 </summary>
    /// <typeparam name="T"> ID 类型。 </typeparam>
    public interface IIDGenerateUtilities<T>
    {
        /// <summary> 产生一个新的 <typeparamref name="T" /> 类型 ID。 </summary>
        /// <param name="args"> 生成新的 ID 所需的扩展参数。 </param>
        /// <returns> <typeparamref name="T" /> 类型 ID。 </returns>
        T NewId(params object[] args);
    }
}