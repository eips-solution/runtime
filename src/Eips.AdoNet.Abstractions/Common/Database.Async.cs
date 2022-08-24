/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.Threading.Tasks;

namespace Niacomsoft.Eips.Data.Common
{
#if !NET40
    public abstract partial class Database : IDbConnectionAsyncInterface
    {
        /// <summary> (异步的方法) 关闭数据库连接。 </summary>
        /// <returns> <see cref="Task" /> 类型的对象实例。 </returns>
        /// <seealso cref="Task" />
        public virtual Task CloseAsync() => Task.Run(() => InternalClose());

        /// <summary> (异步的方法) 打开数据库连接。 </summary>
        /// <returns> <see cref="Task" /> 类型的对象实例。 </returns>
        /// <seealso cref="Task" />
        public virtual Task OpenAsync() => Task.Run(() => InternalOpen());
    }
#endif
}