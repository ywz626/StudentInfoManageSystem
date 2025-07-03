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
        bool addTeacher(string name, string age, string school, string id, int gender);
        bool delete(string id);
        DataTable getTeachers(string tName, string tAgeMin, string tAgeMax, string tSchool, int gender, string id);
        bool update(string name, string age, string school, int gender, string id);
    }
}
