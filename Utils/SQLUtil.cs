using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.Utils
{
    public class SQLUtil
    {
        private StringBuilder _queryBuilder;
        private List<string> _conditions;
        private List<SqlParameter> _parameters;
        private string _connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";

        public SQLUtil(string baseQuery)
        {
            _queryBuilder = new StringBuilder(baseQuery);
            _conditions = new List<string>();
            _parameters = new List<SqlParameter>();
        }

        public SQLUtil()
        {

        }

        // 添加条件的方法
        public void AddCondition(string conditionSql, string paramName, object value)
        {
            if (value != null && !(value is string str && string.IsNullOrWhiteSpace(str)))
            {
                _conditions.Add(conditionSql);
                _parameters.Add(new SqlParameter(paramName, value));
            }
        }

        public void AddBetweenCondition(string field, string paramMin, string valueMin, string paramMax, string valueMax)
        {
            if (valueMin != null && valueMax != null && !string.IsNullOrWhiteSpace(valueMin)&& !string.IsNullOrWhiteSpace(valueMax))
            {
                _conditions.Add($"{field} BETWEEN {paramMin} AND {paramMax}");
                _parameters.Add(new SqlParameter(paramMin, valueMin));
                _parameters.Add(new SqlParameter(paramMax, valueMax));
            }
            else if (valueMin != null && !string.IsNullOrWhiteSpace(valueMin))
            {
                _conditions.Add($"{field} >= {paramMin}");
                _parameters.Add(new SqlParameter(paramMin, valueMin));
            }
            else if (valueMax != null && !string.IsNullOrWhiteSpace(valueMax))
            {
                _conditions.Add($"{field} <= {paramMax}");
                _parameters.Add(new SqlParameter(paramMax, valueMax));
            }
        }
        public void AddBetweenCondition(string field, string paramMin, DateTime valueMin, string paramMax, DateTime valueMax)
        {
            if (valueMin != null && valueMax != null)
            {
                _conditions.Add($"{field} BETWEEN {paramMin} AND {paramMax}");
                _parameters.Add(new SqlParameter(paramMin, valueMin));
                _parameters.Add(new SqlParameter(paramMax, valueMax));
            }
            else if (valueMin != null)
            {
                _conditions.Add($"{field} >= {paramMin}");
                _parameters.Add(new SqlParameter(paramMin, valueMin));
            }
            else if (valueMax != null)
            {
                _conditions.Add($"{field} <= {paramMax}");
                _parameters.Add(new SqlParameter(paramMax, valueMax));
            }
        }

        // 获取完整 SQL
        public string BuildQuery()
        {
            if (_conditions.Count > 0)
            {
                _queryBuilder.Append(" WHERE ");
                _queryBuilder.Append(string.Join(" AND ", _conditions));
            }
            return _queryBuilder.ToString();
        }


        // 获取所有参数
        public SqlParameter[] GetParameters()
        {
            return _parameters.ToArray();
        }

        public int Update(string tableName, Dictionary<string, object> updateFields, Dictionary<string, object> whereConditions)
        {
            if (string.IsNullOrWhiteSpace(tableName)) throw new ArgumentException("表名不能为空");
            if (updateFields == null || updateFields.Count == 0) return 0;
            if (whereConditions == null || whereConditions.Count == 0) throw new ArgumentException("必须提供WHERE条件以防止全表更新");

            List<string> setClauses = new List<string>();
            List<string> whereClauses = new List<string>();
            List<SqlParameter> parameters = new List<SqlParameter>();

            // 构造 SET 语句
            foreach (var item in updateFields)
            {
                if (item.Value != null && item.Value.ToString() != "")
                {
                    string paramName = "@set_" + item.Key;
                    setClauses.Add($"{item.Key} = {paramName}");
                    parameters.Add(new SqlParameter(paramName, item.Value));
                }
            }

            // 构造 WHERE 语句
            foreach (var item in whereConditions)
            {
                string paramName = "@where_" + item.Key;
                whereClauses.Add($"{item.Key} = {paramName}");
                parameters.Add(new SqlParameter(paramName, item.Value));
            }

            if (setClauses.Count == 0) return 0;

            string sql = $"UPDATE {tableName} SET {string.Join(", ", setClauses)} WHERE {string.Join(" AND ", whereClauses)}";

            using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddRange(parameters.ToArray());
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
