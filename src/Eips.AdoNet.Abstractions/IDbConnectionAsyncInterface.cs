/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Threading.Tasks;

namespace Niacomsoft.Eips.Data
{
    /// <summary> 定义了管理数据库连接的异步接口。 </summary>
    /// <seealso cref="IDbConnectionInterface" />
    public interface IDbConnectionAsyncInterface : IDbConnectionInterface
    {
        /// <summary> (异步的方法) 关闭数据库连接。 </summary>
        /// <returns> <see cref="Task" /> 类型的对象实例。 </returns>
        /// <seealso cref="Task" />
        Task CloseAsync();

        /// <summary> (异步的方法) 打开数据库连接。 </summary>
        /// <returns> <see cref="Task" /> 类型的对象实例。 </returns>
        /// <seealso cref="Task" />
        Task OpenAsync();
    }
}