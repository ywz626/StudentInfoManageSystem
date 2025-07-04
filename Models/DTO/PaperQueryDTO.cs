using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.Models.DTO
{
    public class PaperQueryDTO
    {
        public string title { get; set; }
        public string student { get; set; }
        public string teacher { get; set; }
        public DateTime time { get; set; }
        
        public string id { get; set; }
    }
}
