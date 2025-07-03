using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoManageSystem.DAO;

namespace StudentInfoManageSystem.Service.Impl
{
    internal class ClassRoomServiceImpl : ClassRoomService
    {
        public ClassRoomDAO classRoomDAO = new ClassRoomDAO();
        public List<string> getAllBuildings()
        {
            return classRoomDAO.getAllBuildings();
        }

        public DataTable getRooms(string buildingName, string roomName)
        {
            return classRoomDAO.getRooms(buildingName, roomName);
        }
    }
}
