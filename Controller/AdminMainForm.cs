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
    public partial class AdminMainForm : UIForm
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void queryTeachers_Click(object sender, EventArgs e)
        {
            AdminTeacherForm form = new AdminTeacherForm();
            form.Show();
        }

        private void queryStudents_Click(object sender, EventArgs e)
        {
            AdminStudentForm form = new AdminStudentForm();
            form.Show();
        }

        private void queryMajors_Click(object sender, EventArgs e)
        {
            AdminMajorForm adminMajorForm = new AdminMajorForm();
            adminMajorForm.Show();
        }

        private void queryCourse_Click(object sender, EventArgs e)
        {
            AdminCourseForm adminCourseForm = new AdminCourseForm();
            adminCourseForm.Show();
        }

        private void queryPaper_Click(object sender, EventArgs e)
        {
            AdminPaperForm form = new AdminPaperForm();
            form.Show();
        }

        private void queryClassRoom_Click(object sender, EventArgs e)
        {
            AdminRoomForm form = new AdminRoomForm();
            form.Show();
        }
    }
}
