/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips
{
    /// <summary> 定义了生成值类型 ID 的方法接口。 </summary>
    /// <typeparam name="TValueType"> 值类型。 </typeparam>
    /// <seealso cref="IIDGenerateUtilities{T}" />
    public interface IValueTypedIDGenerateUtilities<TValueType> : IIDGenerateUtilities<TValueType>
        where TValueType : struct
    {
    }
}