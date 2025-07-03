using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoManageSystem.DAO;

namespace StudentInfoManageSystem.Service.Impl
{
    internal class MajorServiceImpl : MajorService
    {
        public MajorDAO majorDAO = new MajorDAO();

        public bool addMajor(string majorName, string schoolName, string mId, string sId, string amount)
        {
            int check = majorDAO.addMajor(majorName, schoolName, mId,sId,amount);
            return check > 0;
        }

        public bool delete(string id)
        {
            int check = majorDAO.delete(id);
            return check > 0;
        }

        public List<string> getAllMajor()
        {
            return majorDAO.getMajor();
        }

        public DataTable getMajor(string majorName, string schoolName, string majorId, string schoolId)
        {
            return majorDAO.getMajor(majorName,schoolName,majorId,schoolId);
        }

        public bool update(string name, string amount, string id)
        {
            int check = majorDAO.update(name, amount, id);
            return check > 0;
        }
    }
}
