using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoManageSystem.DAO;
namespace StudentInfoManageSystem.Service.Impl
{
    internal class TeacherServiceImpl : TeacherService
    {
        public TeacherDAO teacherDAO = new TeacherDAO();

        public DataTable getTeachers(string tName, string tAgeMin, string tAgeMax, string tSchool, int gender)
        {
            return teacherDAO.getTeachers(tName, tAgeMin, tAgeMax, tSchool, gender);
        }

    }
}
