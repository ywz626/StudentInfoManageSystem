using StudentInfoManageSystem.Models.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StudentInfoManageSystem.Service
{
    public interface PaperService
    {
        bool addPaper(PaperQueryDTO paperQuery);
        bool delete(string student, string title,string id);
        DataTable getPapers(string studentName, string teacherName, string title,DateTime startTime,DateTime endTime,string id);
        bool update(PaperUpdateDTO paperUpdateDTO);
    }
}
