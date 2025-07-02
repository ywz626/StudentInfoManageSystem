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

namespace StudentInfoManageSystem.Controller
{
    public partial class StudentMainForm : UIForm
    {
        public string uname;
        public StudentMainForm(string uname)
        {
            InitializeComponent();
            this.uname = uname;
        }

        private void queryTeachers_Click(object sender, EventArgs e)
        {
            QueryTeacherInfoForm queryTeacherInfoForm = new QueryTeacherInfoForm(); 
            queryTeacherInfoForm.Show();
        }

        private void queryStudents_Click(object sender, EventArgs e)
        {
            QueryStudentInfoForm queryStudentInfoForm = new QueryStudentInfoForm();
            queryStudentInfoForm.Show();
        }

        private void queryMajors_Click(object sender, EventArgs e)
        {
            MajorInfoForm majorInfoForm = new MajorInfoForm();
            majorInfoForm.Show();
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            headLabel.Text = "欢迎您，" + uname + "同学";
        }

        private void queryCourse_Click(object sender, EventArgs e)
        {
            CourseInfoForm courseInfoForm = new CourseInfoForm();
            courseInfoForm.Show();
        }

        private void queryPaper_Click(object sender, EventArgs e)
        {
            PaperInfoForm paperInfoForm = new PaperInfoForm();
            paperInfoForm.Show();
        }
    }
}
