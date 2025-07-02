using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.DAO.PO
{
    /// <summary>
    /// 教师实体类
    /// 用于存储教师的基本信息
    /// </summary>
    internal class TeacherPO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int sex { get; set; }         // 0: 男, 1: 女
        public int schoolId { get; set; }
    }
}
