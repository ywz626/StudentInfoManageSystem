using StudentInfoManageSystem.Models.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.Service
{
    public interface CourseService
    {
        bool addCourse(CourseQueryDTO queryParams);
        bool delete(string id);
        DataTable getCourse(CourseQueryDTO queryDto);
        bool update(CourseQueryDTO dto);
    }
}
