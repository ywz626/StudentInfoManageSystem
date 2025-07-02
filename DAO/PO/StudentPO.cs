using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.DAO.PO
{
    internal class StudentPO
    {
        public int id { get; set; }
        public string sName { get; set;}

        public string sNumber { get; set; }

        public string major { get; set; }

        // 0是男，1是女
        public int sex { get; set; }

        public string pwd { get; set; }
    }
}
