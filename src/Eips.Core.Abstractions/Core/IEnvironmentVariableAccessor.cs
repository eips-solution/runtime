/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips
{
    /// <summary> 定义了访问环境变量信息的接口。 </summary>
    public interface IEnvironmentVariableAccessor
    {
        /// <summary> 获取指定名称的环境变量信息。 </summary>
        /// <param name="name"> 环境变量名称。 </param>
        /// <returns>
        /// 环境变量信息。
        /// <para> 实现了 <see cref="IEnvironmentVariable" /> 类型接口的对象实例。 </para>
        /// </returns>
        /// <seealso cref="IEnvironmentVariable" />
        IEnvironmentVariable GetEnvironmentVariable(string name);
    }
}