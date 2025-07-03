using StudentInfoManageSystem.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.DAO
{
    internal class ClassRoomDAO
    {
        string connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";

        internal List<string> getAllBuildings()
        {
            string sql = "select name from Buildings";
            List<string> buildings = new List<string>();
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string majorName = reader["name"].ToString();
                    buildings.Add(majorName);
                }
                reader.Close();
            }
            return buildings;
        }

        internal DataTable getRooms(string buildingName, string roomName)
        {
            string query = "select c.name,case when c.status=0 then '正在维修' when c.status=1 then '已占用' else '空闲' end as status,b.name as buildingName from ClassRooms c  join Buildings b on c.buildId=b.buildId";
            DataTable table = new DataTable();
            SQLUtil builder = new SQLUtil(query);
            builder.AddCondition("c.name = @className", "@className",roomName );
            builder.AddCondition("b.name = @buildName", "@buildName", buildingName);
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
