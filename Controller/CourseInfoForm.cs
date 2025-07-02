using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInfoManageSystem.Service;
using StudentInfoManageSystem.Service.Impl;
namespace StudentInfoManageSystem.Controller
{
    public partial class CourseInfoForm : UIForm
    {

        public CourseService courseService = new CourseServiceImpl();
        public CourseInfoForm()
        {
            InitializeComponent();
        }

        private void query_Click(object sender, EventArgs e)
        {
            string name = courseName.Text.Trim();
            string studentNumber  = sNumber.Text.Trim();
            DataTable dataTable = courseService.getCourse(name, studentNumber);
            data.DataSource = dataTable;
            data.Columns["name"].HeaderText = "课程";
            data.Columns["hours"].HeaderText = "学时";
            data.Columns["credit"].HeaderText = "学分";
            data.Columns["teacherName"].HeaderText = "老师";
            data.Columns["general"].HeaderText = "课程类别";
            data.Columns["schoolName"].HeaderText = "所属学院";
            data.Columns["majorName"].HeaderText = "所属专业";
            data.Columns["score"].HeaderText = "成绩";
            data.Columns["status"].HeaderText = "状态";
            data.Columns["studentName"].HeaderText = "学生";
        }
    }
}
