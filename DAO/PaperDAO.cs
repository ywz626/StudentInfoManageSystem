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
    internal class PaperDAO
    {
        private string connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";
        private StudentDAO studentDAO = new StudentDAO();
        private TeacherDAO teacherDAO = new TeacherDAO();

        internal int delete(string student, string title, string id)
        {
            string sql = "";
            int result = 0;
            if (student == null && title == null)
            {
                sql = "delete from Papers where paperId=@paperId ";
                result = 0;
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@paperId", id);
                    conn.Open();
                    result = cmd.ExecuteNonQuery();
                }
                return result;
            }
            sql = "delete from Papers where studentNumber=@studentNumber and title=@title";
            string studentNumber = studentDAO.getStudentNumber(student);
            if (string.IsNullOrEmpty(studentNumber))
            {
                return result;
            }
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
                cmd.Parameters.AddWithValue("@title", title);
                conn.Open();
                result = cmd.ExecuteNonQuery();
            }
            return result;
        }

        internal int addPaper(PaperQueryDTO paperQuery)
        {
            string sql = "INSERT INTO Papers (title, studentNumber, teacherId,publishDate,paperId) VALUES (@title, @studentNumber, @teacherId, @publishDate,@paperId)";
            string studentNumber = studentDAO.getStudentNumber(paperQuery.student);
            int? teacherId = teacherDAO.getTeacherId(paperQuery.teacher);
            int result = 0;
            if (studentNumber == null || teacherId == null)
            {
                return result;
            }
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@title", paperQuery.title);
                cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
                cmd.Parameters.AddWithValue("@teacherId", teacherId);
                cmd.Parameters.AddWithValue("@publishDate", paperQuery.time);
                cmd.Parameters.AddWithValue("@paperId", paperQuery.id);
                conn.Open();
                result = cmd.ExecuteNonQuery();
            }
            return result;
        }

        internal DataTable getPapers(string studentName, string teacherName, string title, DateTime startTime, DateTime endTime, string id)
        {
            string query = "select p.title,s.name as studentName,t.name as teacherName,p.publishDate from Papers p join Students s on p.studentNumber=s.studentNumber join Teachers t on p.teacherId=t.teacherId";
            DataTable table = new DataTable();
            SQLUtil builder = new SQLUtil(query);
            builder.AddCondition("s.name = @name", "@name",studentName );
            builder.AddCondition("t.name = @teacherName", "@teacherName", teacherName);
            builder.AddCondition("p.title = @title", "@title", title);
            builder.AddBetweenCondition("p.publishDate", "@startTime", startTime, "@endTime", endTime);
            builder.AddCondition("p.paperId = @paperId", "@paperId", id);
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

        internal int update(PaperUpdateDTO paperUpdateDTO)
        {
            SQLUtil sqlUtil = new SQLUtil();
            string studentNumber = studentDAO.getStudentNumber(paperUpdateDTO.student);
            int? teacherId = teacherDAO.getTeacherId(paperUpdateDTO.teacher);
            var update = new Dictionary<string, object>
            {
                {"title", paperUpdateDTO.title},
                {"publishDate",paperUpdateDTO.time},
                {"studentNumber",studentNumber},
                {"teacherId",teacherId}
            };
            var where = new Dictionary<string, object>
            {
                {"paperId",paperUpdateDTO.id }
            };
            int rows = sqlUtil.Update("Papers", update, where);
            return rows;
        }
    }
}
