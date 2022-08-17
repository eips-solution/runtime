/* *************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2022 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                      *
\* *************************************************************************************************************************************** */

using System.ComponentModel;

namespace Niacomsoft.Eips.Data
{
    /// <summary> 定义了数据访问程序枚举类型。 </summary>
    public enum DbProvider
    {
        /// <summary> Microsoft SQL Server 数据库访问程序。 </summary>
        [Description("System.Data.SqlClient")]
        SQLServer = 1,

        /// <summary> MySQL 数据库访问程序。 </summary>
        [Description("System.Data.MySQL")]
        MySQL = 2,

        /// <summary> PostgreSQL 数据库访问程序。 </summary>
        [Description("System.Data.PostgreSQL")]
        PostgreSQL = 3,

        /// <summary> Oracle Database 数据库访问程序。 </summary>
        [Description("System.Data.Oracle")]
        OracleDatabase = 4,

        /// <summary> SQLite 数据库访问程序。 </summary>
        [Description("System.Data.SQLite")]
        SQLite = 5,

        /// <summary> REDIS 数据库访问程序。 </summary>
        [Description("System.Data.Documentations.Redis")]
        Redis = 6,

        /// <summary> MongoDB 数据库访问程序。 </summary>
        [Description("System.Data.Documentations.MongoDB")]
        MongoDB = 7,

        /// <summary> 默认的数据库访问程序。等效于 <see cref="SQLServer" />。 </summary>
        [Description("System.Data.SqlClient")]
        Default = SQLServer
    }
}