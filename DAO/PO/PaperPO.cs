using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.DAO.PO
{
    public class PaperPo
    {
        public int id { get; set; }
        public string title { get; set; }
        public int studentId { get; set; }
        public int teacherId { get; set; }
        public DateTime publishDate { get; set; }
    }

}
