using StudentInfoManageSystem.Models.DTO;
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
    internal class StudentDAO
    {
        string connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";


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

        internal DataTable getStudents(string tName, string tAgeMin, string tAgeMax, string sMajor, int? gradeId, int gender)
        {
            string query = "select s.name,s.age,case when s.sex=0 then '男' else '女' end as sex,m.name as majorName,Schools.name as schoolName \r\nfrom Students s join Majors m on s.majorId=m.majorId join Schools on m.schoolId=Schools.schoolId";
            DataTable table = new DataTable();
            SQLUtil builder = new SQLUtil(query);
            builder.AddCondition("s.name = @name", "@name", tName);
            builder.AddCondition("s.sex = @gender", "@gender", gender);
            builder.AddCondition("s.grade = @grade", "@grade", gradeId);
            builder.AddCondition("m.name = @majorName", "@majorName", sMajor);
            builder.AddBetweenCondition("s.age", "@ageMin", tAgeMin, "@ageMax", tAgeMax);
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
