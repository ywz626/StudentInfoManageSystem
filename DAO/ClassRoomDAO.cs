using StudentInfoManageSystem.DAO.PO;
using StudentInfoManageSystem.Models.DTO;
using StudentInfoManageSystem.Utils;
using System;
using System.Collections;
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

        internal DataTable getRooms(RoomQueryDTO queryDTO)
        {
            string query = "select c.name,case when c.status=0 then '维修中' when c.status=1 then '被占用' else '空闲' end as status,b.name as buildingName from ClassRooms c  join Buildings b on c.buildId=b.buildId";
            DataTable table = new DataTable();
            SQLUtil builder = new SQLUtil(query);
            builder.AddCondition("c.name = @className", "@className",queryDTO.roomName );
            builder.AddCondition("b.name = @buildName", "@buildName", queryDTO.buildingName);
            builder.AddCondition("c.status = @status", "@status", queryDTO.statusId);
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

        internal int update(RoomQueryDTO queryDTO)
        {
            Dictionary<string, object> update = null;
            int? statusId = -1;
            if (queryDTO.statusId == null)
            {
                statusId = getStatus(queryDTO);
                if(statusId != 2)
                {
                    return -1;
                }
                statusId = 1;
            }
            else
            {
                statusId = queryDTO.statusId;
            }
            SQLUtil sqlUtil = new SQLUtil();
            string buildId = getBuildId(queryDTO.buildingName);
            string roomId = getRoomId(queryDTO.roomName);
            update = new Dictionary<string, object>
            {
                {"status", statusId},
            };
            var where = new Dictionary<string, object>
            {
                {"buildId",buildId},
                {"roomId",roomId }
            };
            int rows = sqlUtil.Update("ClassRooms", update, where);
            return rows;
        }

        private int getStatus(RoomQueryDTO queryDTO)
        {
            string sql = "select status from ClassRooms where name=@name and buildId=@buildId";
            string buildId = getBuildId(queryDTO.buildingName);
            int status = -1;
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", queryDTO.roomName);
                    cmd.Parameters.AddWithValue("@buildId", buildId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        status =(int) reader["status"];
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }
            return status;
        }

        private string getRoomId(string roomName)
        {
            string sql = "select roomId from ClassRooms where name=@name";
            string roomId = null;
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", roomName);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        roomId = reader["roomId"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            return roomId;
        }

        private string getBuildId(string buildingName)
        {
            string sql = "select buildId from Buildings where name=@name";
            string buildId = null;
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", buildingName);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        buildId = reader["buildId"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            return buildId;
        }
    }
}
