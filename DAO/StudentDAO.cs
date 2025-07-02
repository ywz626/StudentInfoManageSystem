using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace StudentInfoManageSystem.DAO
{
    internal class StudentDAO
    {
        string connStr = "Data Source=localhost;Initial Catalog=StudentDB;Integrated Security=True";


        public bool login(string sName,string sPwd)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "select count(*) from student where name = @sName and pwd = @sPwd";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sName", sName);
                cmd.Parameters.AddWithValue("@sPwd", sPwd);
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
