using StudentInfoManageSystem.DAO.PO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.DAO
{
    internal class MajorDAO
    {
        string connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";
        internal List<string> getAllMajor()
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
    }
}
