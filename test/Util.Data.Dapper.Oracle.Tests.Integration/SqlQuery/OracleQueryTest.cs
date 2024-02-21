using Util.Data.Sql;

namespace Util.Data.Dapper.Tests.SqlQuery {
    /// <summary>
    /// Oracle Sql查询对象测试
    /// </summary>
    public partial class OracleQueryTest {
        /// <summary>
        /// Sql执行器
        /// </summary>
        private readonly ISqlExecutor _sqlExecutor;
        /// <summary>
        /// Sql查询对象
        /// </summary>
        private readonly ISqlQuery _sqlQuery;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public OracleQueryTest( ISqlExecutor sqlExecutor, ISqlQuery sqlQuery ) {
            _sqlExecutor = sqlExecutor;
            _sqlQuery = sqlQuery;
        }
    }
}
