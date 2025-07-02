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
        DataTable getCourse(string name, string studentNumber);
    }
}
