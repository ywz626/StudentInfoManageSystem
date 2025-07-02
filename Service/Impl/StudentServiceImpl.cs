using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoManageSystem.DAO;
using StudentInfoManageSystem.Models.DTO;
using Sunny.UI;
namespace StudentInfoManageSystem.Service.Impl
{
    internal class StudentServiceImpl : StudentService
    {
        StudentDAO studentDAO = new StudentDAO();

        public DataTable getStudents(string tName, string tAgeMin, string tAgeMax, string sMajor, int? gradeId, int gender)
        {
            return studentDAO.getStudents(tName, tAgeMin, tAgeMax, sMajor, gradeId,gender);
        }

        public bool login(string sName, string sNumber)
        {
            StudentLoginDTO studentLoginDTO = new StudentLoginDTO
            {
                sName = sName,
                sNumber = sNumber
            };
            return studentDAO.login(studentLoginDTO);
        }
    }
}
