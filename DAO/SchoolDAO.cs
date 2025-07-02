using StudentInfoManageSystem.DAO.PO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.DAO
{
    internal class SchoolDAO
    {
        string connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";
        public List<string> getAllSchools()
        {
            List<string> schools = new List<string>();
            string sql = "select name from Schools";
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string schoolName = reader["name"].ToString();
                    schools.Add(schoolName);
                }
                reader.Close();
            }
            return schools;
        }
    }
}
