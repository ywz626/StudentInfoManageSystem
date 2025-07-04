using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoManageSystem.DAO;
using StudentInfoManageSystem.Models.DTO;

namespace StudentInfoManageSystem.Service.Impl
{
    internal class ClassRoomServiceImpl : ClassRoomService
    {
        public ClassRoomDAO classRoomDAO = new ClassRoomDAO();
        public List<string> getAllBuildings()
        {
            return classRoomDAO.getAllBuildings();
        }

        public DataTable getRooms(RoomQueryDTO queryDTO)
        {
            return classRoomDAO.getRooms(queryDTO);
        }

        public bool update(RoomQueryDTO queryDTO)
        {
            int check = classRoomDAO.update(queryDTO);
            return check > 0;
        }
    }
}
