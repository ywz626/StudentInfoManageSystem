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
        DataTable getPapers(string studentName, string teacherName, string title,DateTime startTime,DateTime endTime);
    }
}
