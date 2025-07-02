using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoManageSystem.Utils;
namespace StudentInfoManageSystem.DAO
{
    internal class TeacherDAO
    {
        string connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";


        internal DataTable getTeachers(string tName, string tAgeMin, string tAgeMax, string tSchool, int gender)
        {
            string query = "SELECT t.name,t.age,case when t.sex=0 then '男' else '女' end as sex,Schools.name as schoolName FROM Teachers t join Schools ON Schools.schoolId=t.schoolId";
            DataTable table = new DataTable();
            SQLUtil builder = new SQLUtil(query);
            builder.AddCondition("t.name = @name", "@name", tName);
            builder.AddCondition("Schools.name = @schoolName", "@schoolName", tSchool);
            builder.AddCondition("t.sex = @gender", "@gender", gender);
            builder.AddBetweenCondition("t.age", "@ageMin", tAgeMin, "@ageMax", tAgeMax);
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
