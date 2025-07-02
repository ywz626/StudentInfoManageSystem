using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StudentInfoManageSystem.Models.DTO;


namespace StudentInfoManageSystem.DAO
{
    internal class StudentDAO
    {
        string connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";


        public bool login(StudentLoginDTO student)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "select sName from student where sName = @sName and pwd = @sPwd";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sName", student.sName);
                cmd.Parameters.AddWithValue("@sPwd", student.sPwd);
                conn.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
