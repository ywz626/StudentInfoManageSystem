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

        public bool addTeacher(string name, string age, string school, string id, int gender)
        {
            int check = teacherDAO.addTeacher(name, age, school, id, gender);
            return check > 0;
        }

        public bool delete(string id)
        {
            int check = teacherDAO.delete(id);
            return check > 0;
        }

        public DataTable getTeachers(string tName, string tAgeMin, string tAgeMax, string tSchool, int gender, string id)
        {
            return teacherDAO.getTeachers(tName, tAgeMin, tAgeMax, tSchool, gender,id);
        }

        public bool update(string name, string age, string school, int gender, string id)
        {
            int check = teacherDAO.update(name, age, school, gender,id);
            return check > 0;
        }
    }
}
