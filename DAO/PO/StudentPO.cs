using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.DAO.PO
{
    public class StudentPO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int sex { get; set; }
        public string studentNumber { get; set; }
        public int? grade { get; set; }
        public int majorId { get; set; }

        public int? schoolId { get; set; }
    }
}
