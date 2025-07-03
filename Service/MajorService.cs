using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.Service
{
    public interface MajorService
    {
        bool addMajor(string majorName, string schoolName, string mId, string sId, string amount);
        bool delete(string id);
        List<string> getAllMajor();
        DataTable getMajor(string majorName,string schoolName,string majorId,string schoolId);
        bool update(string name, string amount, string id);
    }
}
