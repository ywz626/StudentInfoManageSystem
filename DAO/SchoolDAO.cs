using StudentInfoManageSystem.DAO.PO;
using StudentInfoManageSystem.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        internal void checkSchool(SqlConnection conn, SqlTransaction tr,string sId, string schoolName)
        {
            string query = "select name from Schools where name=@name and schoolId=@schoolId";
            using (SqlCommand cmd = new SqlCommand(query, conn,tr))
            {
                try
                { 
                    cmd.Parameters.AddWithValue("@name", schoolName);
                    cmd.Parameters.AddWithValue("@schoolId", sId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("checkSchool报错", ex);
                }
            }
            // 没有查到对应的学院，开始创建新学院
            string sql = "INSERT INTO Schools (name, schoolId) VALUES (@name, @schoolId)";
            using (SqlCommand cmd = new SqlCommand(sql, conn,tr))
            {
                cmd.Parameters.AddWithValue("@name", schoolName);
                cmd.Parameters.AddWithValue("@schoolId", sId);
                cmd.ExecuteNonQuery();
            }
        }

        internal int? getSchoolId(string school)
        {
            string sql = "select schoolId from Schools where name=@name";
            int? schoolId = null;
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", school);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        schoolId = (int)reader["schoolId"];
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            return schoolId;
        }
    }
}
