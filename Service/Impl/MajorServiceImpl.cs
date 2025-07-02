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
        public List<string> getAllMajor()
        {
            return majorDAO.getMajor();
        }

        public DataTable getMajor(string majorName)
        {
            return majorDAO.getMajor(majorName);
        }
    }
}
