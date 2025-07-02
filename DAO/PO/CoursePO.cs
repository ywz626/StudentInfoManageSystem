using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.DAO.PO
{
    public class CoursePO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int hours { get; set; }
        public float credit { get; set; }
        public int teacherId { get; set; }
        public int? majorId { get; set; }     // 通识课允许为空
        public bool isGeneral { get; set; }
        public int schoolId { get; set; }
    }

}
