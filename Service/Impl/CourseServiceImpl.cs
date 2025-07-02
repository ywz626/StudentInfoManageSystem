using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoManageSystem.DAO;

namespace StudentInfoManageSystem.Service.Impl
{
    internal class CourseServiceImpl : CourseService
    {
        public CourseDAO courseDAO = new CourseDAO();

        public DataTable getCourse(string name, string studentNumber)
        {
            return courseDAO.getCourse(name, studentNumber);
        }
    }
}
