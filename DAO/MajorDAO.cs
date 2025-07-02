using StudentInfoManageSystem.DAO.PO;
using StudentInfoManageSystem.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.DAO
{
    internal class MajorDAO
    {
        string connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";
        internal List<string> getMajor()
        {
            string sql = "select name from Majors";
            List<string> majors = new List<string>();
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string majorName = reader["name"].ToString();
                    majors.Add(majorName);
                }
                reader.Close();
            }
            return majors;
        }

        internal DataTable getMajor(string majorName)
        {
            string query = "select m.name,m.studentAmount,Schools.name as SchoolName from Majors m join Schools on m.schoolId=Schools.schoolId";
            DataTable table = new DataTable();
            SQLUtil builder = new SQLUtil(query);
            builder.AddCondition("m.name = @name", "@name", majorName);
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = builder.BuildQuery();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(builder.GetParameters());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                }
            }
            return table;
        }
    }
}
