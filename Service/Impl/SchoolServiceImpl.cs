using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoManageSystem.DAO;

namespace StudentInfoManageSystem.Service.Impl
{
    public class SchoolServiceImpl : SchoolService
    {
        SchoolDAO schoolDAO = new SchoolDAO();

        public List<string> getAllSchools()
        {
            return schoolDAO.getAllSchools();
        }
    }
}
