/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Threading.Tasks;

namespace Niacomsoft.Eips
{
    /// <summary> 提供了异步访问环境变量信息相关的方法。 </summary>
    /// <seealso cref="IEnvironmentVariableAccessor" />
    public interface IAsyncEnvironmentVariableAccessor : IEnvironmentVariableAccessor
    {
        /// <summary> (异步的方法) 获取指定名称的环境变量。 </summary>
        /// <param name="name"> 环境变量名称。 </param>
        /// <returns> 环境变量信息。 </returns>
        /// <seealso cref="IEnvironmentVariable" />
        /// <seealso cref="Task{TResult}" />
        Task<IEnvironmentVariable> GetEnvironmentVariableAsync(string name);
    }
}