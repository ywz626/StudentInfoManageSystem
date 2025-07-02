using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.Service
{
    public interface StudentService
    {

         bool login(string sName, string sPwd);
    }
}
