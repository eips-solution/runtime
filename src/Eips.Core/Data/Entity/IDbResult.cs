/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

namespace Niacomsoft.Eips.Data.Entity
{
    /// <summary> 定义了数据库结果接口。 </summary>
    public interface IDbResult
    {
        /// <summary> 数据库事务是否执行成功。 </summary>
        /// <value> 设置或获取一个值，用于表示数据库事务是否执行成功。 </value>
        bool Completed { get; set; }

        /// <summary> 数据库事务执行异常。 </summary>
        /// <value> 设置或获取 <see cref="DbExecutionException" /> 类型的对象实例，用于表示数据库事务执行异常。 </value>
        /// <seealso cref="DbExecutionException" />
        DbExecutionException ExecutionException { get; set; }
    }

    /// <summary> 定义了包含数据结果的数据库结果接口。 </summary>
    /// <typeparam name="T"> 数据结果类型。 </typeparam>
    /// <seealso cref="IDbResult" />
    public interface IDbResult<T> : IDbResult
    {
        /// <summary> 数据库结果。 </summary>
        /// <value> 设置或获取 <typeparamref name="T" /> 类型的对象实例或值，用于表示数据库结果。 </value>
        T Result { get; set; }
    }
}