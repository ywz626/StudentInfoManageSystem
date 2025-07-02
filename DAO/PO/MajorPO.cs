using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.DAO.PO
{
    public class MajorPO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int studentAmount { get; set; }
        public int schoolId { get; set; }
    }
}
