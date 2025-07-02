using StudentInfoManageSystem.Service;
using StudentInfoManageSystem.Service.Impl;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
namespace StudentInfoManageSystem.Controller
{
    public partial class QueryStudentInfoForm : UIForm
    {

        public StudentService studentService = new StudentServiceImpl();
        public MajorService majorService = new MajorServiceImpl();
        public QueryStudentInfoForm()
        {
            InitializeComponent();
        }

        private void query_Click(object sender, EventArgs e)
        {
            string sname = sName.Text.Trim();
            string sminAge = sMinAge.Text.Trim();
            string smaxAge = sMaxAge.Text.Trim();
            string smajor = sMajor.Text.Trim();
            string sgrade = sGrade.Text.Trim();
            int gender = -1;
            if (sex0.Checked)
            {
                gender = 0;
            }
            else
            {
                gender = 1;
            }
            int? gradeId = null;
            if (sGrade.Equals("研一"))
            {
                gradeId = 1;
            }
            else if (sGrade.Equals("研二"))
            {
                gradeId = 2;
            }
            else if (sGrade.Equals("研三"))
            {
                gradeId = 3;
            }
            DataTable table = studentService.getStudents(sname, sminAge, smaxAge, smajor, gradeId, gender);
            data.DataSource = table;
            data.Columns["name"].HeaderText = "姓名";
            data.Columns["age"].HeaderText = "年龄";
            data.Columns["sex"].HeaderText = "性别";
            data.Columns["majorName"].HeaderText = "专业";
            data.Columns["schoolName"].HeaderText = "所属学院";
        }

        private void 学生信息查询_Load(object sender, EventArgs e)
        {
            sGrade.Items.Add("研一");
            sGrade.Items.Add("研二");
            sGrade.Items.Add("研三");
            List<string> majors = majorService.getAllMajor();
            foreach (string item in majors)
            {
                sMajor.Items.Add(item);
            }
        }

    }
}
