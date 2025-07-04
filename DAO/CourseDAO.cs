using StudentInfoManageSystem.DAO.PO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentInfoManageSystem.DAO
{
    internal class CourseDAO
    {
        string connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";
        public TeacherDAO teacherDAO = new TeacherDAO();
        public MajorDAO majorDAO = new MajorDAO();
        public SchoolDAO schoolDAO = new SchoolDAO();
        internal int addCourse(CourseQueryDTO queryParams)
        {
            string sql = "INSERT INTO Courses (name, hours, credit, teacherId, majorId, isGeneral, schoolId, courseId) VALUES (@Name, @Hours, @Credit, @TeacherId, @MajorId, @IsGeneral, @SchoolId, @CourseId)";
            int? teacherId = teacherDAO.getTeacherId(queryParams.TeacherName);
            int? majorId = majorDAO.getMajorId(queryParams.MajorName);
            int? schoolId = schoolDAO.getSchoolId(queryParams.SchoolName);
            if(teacherId == null || majorId == null || schoolId == null)
            {
                return 0; // Return 0 if any of the IDs are not found
            }
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", queryParams.Name);
                    cmd.Parameters.AddWithValue("@Hours", queryParams.StudyHour);
                    cmd.Parameters.AddWithValue("@Credit", queryParams.StudyScore);
                    cmd.Parameters.AddWithValue("@TeacherId", teacherId);
                    cmd.Parameters.AddWithValue("@MajorId", majorId);
                    cmd.Parameters.AddWithValue("@IsGeneral", queryParams.CourseTypeName);
                    cmd.Parameters.AddWithValue("@SchoolId", schoolId);
                    cmd.Parameters.AddWithValue("@CourseId", queryParams.CourseId);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        internal DataTable getCourse(CourseQueryDTO queryDTO)
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
            string query = "select c.name, c.hours, c.credit, case when c.isGeneral = 0 then '通识课' else '专业课' end as general, t.name as teacherName, m.name as majorName, s.name as schoolName, sc.score, case when sc.status = 0 then '未开课' when sc.status = 1 then '正在进行' else '已结课' end as status, st.name as studentName from Courses c join Majors m on c.majorId = m.majorId join Teachers t on c.teacherId = t.teacherId join Schools s on c.schoolId = s.schoolId join StudentCourse sc on sc.courseId = c.courseId join Students st on st.studentNumber = sc.studentNumber";
            DataTable table = new DataTable();
            SQLUtil builder = new SQLUtil(query);
            builder.AddCondition("c.name = @name", "@name", queryDTO.Name);
            builder.AddCondition("sc.studentNumber = @studentNumber", "@studentNumber", queryDTO.StudentNumber);
            builder.AddCondition("m.name = @majorName", "@majorName", queryDTO.MajorName);
            builder.AddCondition("s.name = @schoolName", "@schoolName", queryDTO.SchoolName);
            builder.AddCondition("c.isGeneral= @courseType", "@courseType", queryDTO.CourseTypeName);
            builder.AddCondition("c.credit = @credit", "@credit", queryDTO.StudyScore);
            builder.AddCondition("c.hours = @hours", "@hours", queryDTO.StudyHour);
            builder.AddCondition("t.name = @teacherName", "@teacherName", queryDTO.TeacherName);
            builder.AddCondition("c.courseId = @courseId", "@courseId", queryDTO.CourseId);
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
            string sql = "delete from Courses where courseId=@courseId";
            int result = 0;
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@courseId", id);
                conn.Open();
                result = cmd.ExecuteNonQuery();
            }
            return result;
        }

        internal int update(CourseQueryDTO dto)
        {
            SQLUtil sqlUtil = new SQLUtil();
            int? teacherId = teacherDAO.getTeacherId(dto.TeacherName);
            int? majorId = majorDAO.getMajorId(dto.MajorName);
            int? schoolId = schoolDAO.getSchoolId(dto.SchoolName);
            var update = new Dictionary<string, object>
            {
                {"name", dto.Name},
                {"credit",dto.StudyScore},
                {"hours",dto.StudyHour},
                {"teacherId",teacherId},
                {"majorId", majorId},
                {"isGeneral",dto.CourseTypeName},
                {"schoolId",schoolId},
            };
            var where = new Dictionary<string, object>
            {
                {"courseId",dto.CourseId}
            };
            int rows = sqlUtil.Update("Courses", update, where);
            return rows;
        }
    }
}
