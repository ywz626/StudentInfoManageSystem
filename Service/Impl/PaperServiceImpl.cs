using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoManageSystem.DAO;
namespace StudentInfoManageSystem.Service.Impl
{
    internal class PaperServiceImpl : PaperService
    {

        public PaperDAO paperDAO = new PaperDAO();
        public DataTable getPapers(string studentName, string teacherName, string title, DateTime startTime, DateTime endTime)
        {
            return paperDAO.getPapers(studentName, teacherName, title,startTime,endTime);
        }
    }
}
