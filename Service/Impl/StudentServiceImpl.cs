using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoManageSystem.DAO;
using StudentInfoManageSystem.Models.DTO;
namespace StudentInfoManageSystem.Service.Impl
{
    internal class StudentServiceImpl : StudentService
    {
        StudentDAO studentDAO = new StudentDAO();
        public bool login(string sName, string sPwd)
        {
            StudentLoginDTO studentLoginDTO = new StudentLoginDTO
            {
                sName = sName,
                sPwd = sPwd
            };
            return studentDAO.login(studentLoginDTO);
        }
    }
}
