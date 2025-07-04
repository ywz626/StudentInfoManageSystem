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
    public class StudentServiceImpl : StudentService
    {
        private StudentDAO studentDAO = new StudentDAO();

        public bool addStudent(string sname, string age, string school, string sNumber, int gender, string sgrade, string smajor)
        {
            int check = studentDAO.addStudent(sname, age, school, sNumber, gender, sgrade, smajor);
            return check > 0;
        }

        public bool delete(string id)
        {
            int check = studentDAO.delete(id);
            return check > 0;
        }

        public DataTable getStudents(string sName, string sAgeMin, string sAgeMax, string sMajor, int? gradeId, int gender, string sNumber, string school)
        {
            return studentDAO.getStudents(sName, sAgeMin, sAgeMax, sMajor, gradeId,gender,sNumber,school);
        }

        public string login(StudentLoginDTO dto)
        {
            return studentDAO.login(dto);
        }

        public bool update(string sname, string age, string smajor, string sgrade, string id, string school, int gender)
        {
            int check = studentDAO.update(sname, age, smajor, sgrade, id, school, gender);
            return check > 0;
        }

        public bool updatePwd(string newpwd)
        {
            int check = studentDAO.updatePwd(newpwd);
            return check > 0;
        }
    }
}
