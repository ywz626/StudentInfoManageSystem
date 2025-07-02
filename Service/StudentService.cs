using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.Service
{
    public interface StudentService
    {
        DataTable getStudents(string tName, string tAgeMin, string tAgeMax, string sMajor, int? gradeId, int gender);
        bool login(string sName, string sNumber);
    }
}
