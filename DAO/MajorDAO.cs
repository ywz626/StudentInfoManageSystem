using StudentInfoManageSystem.DAO.PO;
using StudentInfoManageSystem.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentInfoManageSystem.DAO
{
    internal class MajorDAO
    {
        public SchoolDAO schoolDAO = new SchoolDAO();
        string connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";

        internal int addMajor(string majorName, string schoolName, string mId, string sId, string amount)
        {
            string sql = "INSERT INTO Majors (name, studentAmount, schoolId, majorId) VALUES (@name, @studentAmount, @schoolId, @majorId)";
            int result = 0;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open(); 
                SqlTransaction transaction = conn.BeginTransaction(); 

                try
                {
                    schoolDAO.checkSchool(conn,transaction, sId, schoolName);

                    using (SqlCommand cmd = new SqlCommand(sql, conn, transaction)) 
                    {
                        cmd.Parameters.AddWithValue("@name", majorName);
                        cmd.Parameters.AddWithValue("@schoolId", sId);
                        cmd.Parameters.AddWithValue("@studentAmount", amount);
                        cmd.Parameters.AddWithValue("@majorId", mId);
                        result = cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("发生回滚", ex);
                }
            }

            return result;
        }

        internal int delete(string id)
        {
            string sql = "delete from Majors where majorId=@majorId";
            int result = 0;
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@majorId", id);
                conn.Open();
                result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return result;
        }

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

        internal DataTable getMajor(string majorName, string schoolName,string majorId,string schoolId)
        {
            string query = "select m.name,m.studentAmount,Schools.name as SchoolName from Majors m join Schools on m.schoolId=Schools.schoolId";
            DataTable table = new DataTable();
            int? schoolId2 = null;
            if (!string.IsNullOrEmpty(schoolId))
            {
                schoolId2 = int.Parse(schoolId);
            }
            if (string.IsNullOrEmpty(schoolId) && !string.IsNullOrEmpty(schoolName))
            {
                schoolId2 = schoolDAO.getSchoolId(schoolName);
            }
            SQLUtil builder = new SQLUtil(query);
            builder.AddCondition("m.name = @name", "@name", majorName);
            builder.AddCondition("m.majorId = @majorId", "@majorId", majorId);
            builder.AddCondition("m.schoolId = @schoolId", "@schoolId", schoolId2);
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

        internal int? getMajorId(string major)
        {
            string sql = "select majorId from Majors where name=@name";
            int? majorId = null;
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", major);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        majorId = (int)reader["majorId"];
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            return majorId;
        }

        internal int update(string name, string amount, string id)
        {
            SQLUtil sqlUtil = new SQLUtil();
            var update = new Dictionary<string, object>
            {
                {"name", name},
                {"studentAmount",amount },
            };
            var where = new Dictionary<string, object>
            {
                {"majorId",id }
            };
            int rows = sqlUtil.Update("Majors", update, where);
            return rows;
        }
    }
}
