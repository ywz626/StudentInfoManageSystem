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
        bool addStudent(string sname, string age, string school, string sNumber, int gender, string sgrade, string smajor);
        bool delete(string id);
        DataTable getStudents(string sName, string sAgeMin, string sAgeMax, string sMajor, int? gradeId, int gender,string sNumber,string school);
        bool login(string sName, string sNumber);
        bool update(string sname, string age, string smajor, string sgrade, string id, string school, int gender);
    }
}
