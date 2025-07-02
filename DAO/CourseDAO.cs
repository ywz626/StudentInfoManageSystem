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
    internal class CourseDAO
    {
        string connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";
        internal DataTable getCourse(string name, string studentNumber)
        {
            //string query;
            //DataTable table = new DataTable();
            //SQLUtil builder;
            //if (string.IsNullOrEmpty(studentNumber))
            //{
            //    query = "select c.name,c.hours,c.credit,case when c.isGeneral=0 then '通识课' ELSE '专业课' end as general,t.name as teacherName,m.name as majorName,s.name as schoolName from Courses c join Majors m on c.majorId=m.majorId join Teachers t on c.teacherId=t.teacherId join Schools s on c.schoolId=s.schoolId";
            //    table = new DataTable();
            //    builder = new SQLUtil(query);
            //    builder.AddCondition("c.name = @name", "@name", name);
            //    using (SqlConnection conn = new SqlConnection(connStr))
            //    {
            //        conn.Open();
            //        string sql = builder.BuildQuery();
            //        using (SqlCommand cmd = new SqlCommand(sql, conn))
            //        {
            //            cmd.Parameters.AddRange(builder.GetParameters());
            //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //            adapter.Fill(table);
            //        }
            //    }
            //    return table;
            //}
            //if(string.IsNullOrEmpty(name))
            //{
            //    query = "select c.name,c.hours,c.credit,case when c.isGeneral=0 then '通识课' ELSE '专业课' end as general,t.name as teacherName,m.name as majorName,s.name as schoolName,sc.score,case when sc.status=0 then '未开课' when sc.status=1 then '正在进行' else '已结课' end as source from Courses c join Majors m on c.majorId=m.majorId join Teachers t on c.teacherId=t.teacherId join Schools s on c.schoolId=s.schoolId join StudentCourse sc on sc.courseId=c.courseId";
            //    table = new DataTable();
            //    builder = new SQLUtil(query);
            //    builder.AddCondition("sc.studentNumber = @studentNumber", "@studentNumber", studentNumber);
            //    using (SqlConnection conn = new SqlConnection(connStr))
            //    {
            //        conn.Open();
            //        string sql = builder.BuildQuery();
            //        using (SqlCommand cmd = new SqlCommand(sql, conn))
            //        {
            //            cmd.Parameters.AddRange(builder.GetParameters());
            //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //            adapter.Fill(table);
            //        }
            //    }
            //    return table;
            //}
            //query = "select c.name,c.hours,c.credit,case when c.isGeneral=0 then '通识课' ELSE '专业课' end as general,t.name as teacherName,m.name as majorName,s.name as schoolName,sc.score,case when sc.status=0 then '未开课' when sc.status=1 then '正在进行' else '已结课' end as status from Courses c join Majors m on c.majorId=m.majorId join Teachers t on c.teacherId=t.teacherId join Schools s on c.schoolId=s.schoolId join StudentCourse sc on sc.courseId=c.courseId";
            //table = new DataTable();
            //builder = new SQLUtil(query);
            //builder.AddCondition("c.name = @name", "@name", name);
            //builder.AddCondition("sc.studentNumber = @studentNumber", "@studentNumber", studentNumber);
            //using (SqlConnection conn = new SqlConnection(connStr))
            //{
            //    conn.Open();
            //    string sql = builder.BuildQuery();
            //    using (SqlCommand cmd = new SqlCommand(sql, conn))
            //    {
            //        cmd.Parameters.AddRange(builder.GetParameters());
            //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //        adapter.Fill(table);
            //    }
            //}
            //return table;
            string query = "select c.name,c.hours,c.credit,case when c.isGeneral=0 then '通识课' ELSE '专业课' end as general,t.name as teacherName,m.name as majorName,s.name as schoolName,sc.score,case when sc.status=0 then '未开课' when sc.status=1 then '正在进行' else '已结课' end as status,st.name as studentName from Courses c join Majors m on c.majorId=m.majorId join Teachers t on c.teacherId=t.teacherId join Schools s on c.schoolId=s.schoolId join StudentCourse sc on sc.courseId=c.courseId join Students st on st.studentNumber=sc.studentId";
            DataTable table = new DataTable();
            SQLUtil builder = new SQLUtil(query);
            builder.AddCondition("c.name = @name", "@name", name);
            builder.AddCondition("sc.studentId = @studentId", "@studentId", studentNumber);
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
