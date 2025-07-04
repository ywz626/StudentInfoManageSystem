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
    internal class CourseServiceImpl : CourseService
    {
        public CourseDAO courseDAO = new CourseDAO();

        public bool addCourse(CourseQueryDTO queryParams)
        {
            int check = courseDAO.addCourse(queryParams);
            return check > 0;
        }

        public bool delete(string id)
        {
            int check = courseDAO.delete(id);
            return check > 0;
        }

        public DataTable getCourse(CourseQueryDTO courseQueryDTO)
        {
            return courseDAO.getCourse(courseQueryDTO);
        }

        public bool update(CourseQueryDTO dto)
        {
            int check = courseDAO.update(dto);
            return check > 0;
        }
    }
}
