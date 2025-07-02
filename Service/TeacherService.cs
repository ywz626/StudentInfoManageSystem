using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.Service
{
    public interface TeacherService
    {
        DataTable getTeachers(string tName, string tAgeMin, string tAgeMax, string tSchool, int gender);
    }
}
