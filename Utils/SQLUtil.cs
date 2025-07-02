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

        public SQLUtil(string baseQuery)
        {
            _queryBuilder = new StringBuilder(baseQuery);
            _conditions = new List<string>();
            _parameters = new List<SqlParameter>();
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
    }
}
