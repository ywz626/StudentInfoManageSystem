using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoManageSystem.DAO;
using StudentInfoManageSystem.Models.DTO;
namespace StudentInfoManageSystem.Service.Impl
{
    public class PaperServiceImpl : PaperService
    {

        private PaperDAO paperDAO = new PaperDAO();

        public bool addPaper(PaperQueryDTO paperQuery)
        {
            int check = paperDAO.addPaper(paperQuery);
            return check > 0;
        }

        public bool delete(string student, string title, string id)
        {
            int check = paperDAO.delete(student, title,id);
            return check > 0;
        }

        public DataTable getPapers(string studentName, string teacherName, string title, DateTime startTime, DateTime endTime, string id)
        {
            return paperDAO.getPapers(studentName, teacherName, title,startTime,endTime,id);
        }

        public bool update(PaperUpdateDTO paperUpdateDTO)
        {
            int check = paperDAO.update(paperUpdateDTO);
            return check > 0;
        }
    }
}
