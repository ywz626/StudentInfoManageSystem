using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManageSystem.Models.DTO
{
    public class CourseQueryDTO
    {
        public string Name { get; set; }           // 课程名称
        public string MajorName { get; set; }       // 专业名称
        public string SchoolName { get; set; }      // 学院名称
        public int? CourseTypeName { get; set; }  // 课程类型名称
        public string StudyHour { get; set; }       // 学时（保留为字符串以支持范围查询）
        public string StudyScore { get; set; }      // 学分（保留为字符串以支持范围查询）
        public string StudentNumber { get; set; }   // 学生学号
        public string CourseId { get; set; }        // 课程ID
        public string TeacherName { get; set; }     // 教师姓名
    }
}
