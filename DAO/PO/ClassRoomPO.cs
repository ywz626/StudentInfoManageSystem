using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.DAO.PO
{
    public class ClassRoomPO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string building { get; set; }
        public string status { get; set; }     // 可用 / 占用中 / 维修中
        public int schoolId { get; set; }
    }

}
