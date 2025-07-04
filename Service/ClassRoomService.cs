using StudentInfoManageSystem.Models.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.Service
{
    public interface ClassRoomService
    {
        List<string> getAllBuildings();
        DataTable getRooms(RoomQueryDTO queryDTO);
        bool update(RoomQueryDTO queryDTO);
    }
}
