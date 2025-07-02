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
    internal class PaperDAO
    {
        string connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";
        internal DataTable getPapers(string studentName, string teacherName, string title, DateTime startTime, DateTime endTime)
        {
            string query = "select p.title,s.name as studentName,t.name as teacherName,p.publishDate from Papers p join Students s on p.studentId=s.studentNumber join Teachers t on p.teacherId=t.teacherId";
            DataTable table = new DataTable();
            SQLUtil builder = new SQLUtil(query);
            builder.AddCondition("s.name = @name", "@name",studentName );
            builder.AddCondition("t.name = @teacherName", "@teacherName", teacherName);
            builder.AddCondition("p.title = @title", "@title", title);
            builder.AddBetweenCondition("p.publishDate", "@startTime", startTime, "@endTime", endTime);
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
