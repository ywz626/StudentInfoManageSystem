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
        public StudentMainForm()
        {
            InitializeComponent();
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
    }
}
