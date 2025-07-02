using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.DAO.PO
{
    /// <summary>
    /// 学院实体类
    /// 用于存储学院的基本信息
    /// </summary>
    internal class SchoolPO
    {

        public int id { get; set; }
        public int SchoolId { get; set; }
        
        /// <summary>
        /// 学院名称
        /// </summary>
        public string SchoolName { get; set; }
        
    }
}
