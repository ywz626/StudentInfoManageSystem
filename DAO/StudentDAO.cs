using StudentInfoManageSystem.Models.DTO;
using StudentInfoManageSystem.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace StudentInfoManageSystem.DAO
{
    internal class StudentDAO
    {
        string connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";
        public SchoolDAO schoolDAO = new SchoolDAO();
        public MajorDAO majorDAO = new MajorDAO();
        public bool login(StudentLoginDTO student)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "select name from Students where name = @name and studentNumber = @studentNumber";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", student.sName);
                cmd.Parameters.AddWithValue("@studentNumber", student.sNumber);
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

        internal DataTable getStudents(string sName, string sAgeMin, string sAgeMax, string sMajor, int? gradeId, int gender, string sNumber, string school)
        {
            string query = "select s.name,s.age,case when s.sex=0 then '男' else '女' end as sex,m.name as majorName,Schools.name as schoolName,s.studentNumber \r\nfrom Students s join Majors m on s.majorId=m.majorId join Schools on m.schoolId=Schools.schoolId";
            DataTable table = new DataTable();
            SQLUtil builder = new SQLUtil(query);
            int? schoolId = null;
            if (!string.IsNullOrEmpty(school))
            {
                schoolId = schoolDAO.getSchoolId(school);
            }
            builder.AddCondition("s.name = @name", "@name", sName);
            builder.AddCondition("s.studentNumber= @sNum", "@sNum", sNumber);
            builder.AddCondition("s.sex = @gender", "@gender", gender);
            builder.AddCondition("s.grade = @grade", "@grade", gradeId);
            builder.AddCondition("m.name = @majorName", "@majorName", sMajor);
            builder.AddBetweenCondition("s.age", "@ageMin", sAgeMin, "@ageMax", sAgeMax);
            builder.AddCondition("s.schoolId = @schoolId", "@schoolId", schoolId);
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

        internal int addStudent(string sname, string age, string school, string sNumber, int gender, string sgrade, string smajor)
        {

            string sql = "INSERT INTO Students (name, age, sex,schoolId ,majorId,grade) VALUES (@name, @age, @sex, @schoolId, @majorId,@grade)";
            int? schoolId = schoolDAO.getSchoolId(school);
            int? majorId = majorDAO.getMajorId(smajor);
            int result = 0;
            if (schoolId == null || majorId == null)
            {
                return result;
            }
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@name", sname);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@sex", gender);
                cmd.Parameters.AddWithValue("@schoolId", schoolId);
                cmd.Parameters.AddWithValue("@studentNumber", sNumber);
                cmd.Parameters.AddWithValue("@grade", sgrade);
                cmd.Parameters.AddWithValue("@majorId", majorId);
                conn.Open();
                result = cmd.ExecuteNonQuery();
            }
            return result;
        }

        internal int delete(string id)
        {
            string sql = "delete from Students where studentNumber=@studentNumber";
            int result = 0;
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@studentNumber", id);
                conn.Open();
                result = cmd.ExecuteNonQuery();
            }
            return result;
        }

        internal int update(string sname, string age, string smajor, string sgrade, string id, string school, int gender)
        {
            SQLUtil sqlUtil = new SQLUtil();
            int? schoolId = null;
            int? majorId = null;
            if (!string.IsNullOrEmpty(school))
            {
                schoolId = schoolDAO.getSchoolId(school);
                if (schoolId == null)
                {
                    return 0;
                }
            }
            if (!string.IsNullOrEmpty(smajor))
            {
                majorId = majorDAO.getMajorId(smajor);
                if(majorId == null)
                {
                    return 0;
                }
            }
            var update = new Dictionary<string, object>
            {
                {"name", sname},
                {"age",age },
                {"schoolId",schoolId },
                {"majorId",majorId },
                {"grade",sgrade },
                {"sex",gender }
            };
            var where = new Dictionary<string, object>
            {
                {"studentNumber",id }
            };
            int rows = sqlUtil.Update("Students", update, where);
            return rows;
        }
    }
}
