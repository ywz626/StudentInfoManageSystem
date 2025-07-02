using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoManageSystem.DAO;
namespace StudentInfoManageSystem.Service.Impl
{
    internal class StudentServiceImpl : StudentService
    {
        StudentDAO studentDAO = new StudentDAO();
        public bool login(string sName, string sPwd)
        {
            return studentDAO.login(sName, sPwd);
        }
    }
}
