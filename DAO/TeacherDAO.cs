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
    internal class TeacherDAO
    {
        string connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";

        public SchoolDAO schoolDAO = new SchoolDAO();

        internal int addTeacher(string name, string age, string school, string id, int gender)
        {

            string sql = "INSERT INTO Teachers (name, age, sex,schoolId , teacherId) VALUES (@name, @age, @sex, @schoolId, @teacherId)";
            int? schoolId = schoolDAO.getSchoolId(school);
            int result = 0;
            if (schoolId == null)
            {
                return result;
            }
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@sex", gender);
                cmd.Parameters.AddWithValue("@schoolId", schoolId);
                cmd.Parameters.AddWithValue("@teacherId", id);
                conn.Open();
                result = cmd.ExecuteNonQuery();
            }
            return result;
        }

        internal DataTable getTeachers(string tName, string tAgeMin, string tAgeMax, string tSchool, int gender, string id)
        {
            string query = "SELECT t.name,t.age,case when t.sex=0 then '男' else '女' end as sex,Schools.name as schoolName,t.teacherId FROM Teachers t join Schools ON Schools.schoolId=t.schoolId";
            DataTable table = new DataTable();
            SQLUtil builder = new SQLUtil(query);
            builder.AddCondition("t.name = @name", "@name", tName);
            builder.AddCondition("Schools.name = @schoolName", "@schoolName", tSchool);
            builder.AddCondition("t.sex = @gender", "@gender", gender);
            builder.AddBetweenCondition("t.age", "@ageMin", tAgeMin, "@ageMax", tAgeMax);
            builder.AddCondition("t.teacherId= @id", "@id", id);
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

        internal int delete(string id)
        {
            string sql = "delete from Teachers where teacherId=@teacherId";
            int result = 0;
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@teacherId", id);
                conn.Open();
                result = cmd.ExecuteNonQuery();
            }
            return result;
        }

        internal int update(string name, string age, string school, int gender, string id)
        {
            SQLUtil sqlUtil = new SQLUtil();
            int? schoolId = null;
            if (!string.IsNullOrEmpty(school))
            {
                schoolId = schoolDAO.getSchoolId(school);
                if (schoolId == null)
                {
                    return 0;
                }
            }
            var update = new Dictionary<string, object>
            {
                {"name", name},
                {"age",age },
                {"schoolId",schoolId },
                {"sex",gender }
            };
            var where = new Dictionary<string, object>
            {
                {"teacherId",id }
            };
            int rows = sqlUtil.Update("Teachers",update, where);
            return rows;
        }
    }
}
