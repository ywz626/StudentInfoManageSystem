using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoManageSystem.Models.DTO
{
    public class RoomQueryDTO
    {
        public string buildingName {  get; set; }
        public string roomName {  get; set; }
        public string status {  get; set; }
        public int? statusId {  get; set; }
    }
}
