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
    public partial class AdminTeacherForm : UIForm
    {

        public TeacherService teacherService = new TeacherServiceImpl();

        public SchoolService schoolService = new SchoolServiceImpl();
        public AdminTeacherForm()
        {
            InitializeComponent();
        }

        private void query_Click(object sender, EventArgs e)
        {
            string name = tName.Text.Trim();
            string age = tAge.Text.Trim();
            string school = tSchool.Text.Trim();
            string id = tId.Text.Trim();
            int gender = -1;
            if (sex0.Checked)
            {
                gender = 0;
            }
            else
            {
                gender = 1;
            }
            QueryTeacherInfoForm queryTeacherInfoForm = new QueryTeacherInfoForm(name,age,school,id,gender);
            queryTeacherInfoForm.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string name = tName.Text.Trim();
            string age = tAge.Text.Trim();
            string school = tSchool.Text.Trim();
            string id = tId.Text.Trim();
            int gender = -1;
            if (sex0.Checked)
            {
                gender = 0;
            }
            else
            {
                gender = 1;
            }
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(school) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("信息不全请重新填写");
                return;
            }
            bool check = teacherService.addTeacher(name,age,school,id,gender);
            if (check)
            {
                MessageBox.Show("插入成功！！！");
            }
            else
            {
                MessageBox.Show("插入失败！！！");
            }
        }

        private void AdminTeacherForm_Load(object sender, EventArgs e)
        {
            List<string> schools = schoolService.getAllSchools();
            foreach (string school in schools)
            {
                tSchool.Items.Add(school);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string id = tId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("请务必填写教师编号！");
                return;
            }
            DialogResult result = MessageBox.Show("你确定要删除么？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool check = teacherService.delete(id);
                if (check)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }    
        }

        private void update_Click(object sender, EventArgs e)
        {
            string id = tId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("请务必填写教师编号！");
                return;
            }
            string name = tName.Text.Trim();
            string age = tAge.Text.Trim();
            string school = tSchool.Text.Trim();
            int gender = -1;
            if (sex0.Checked)
            {
                gender = 0;
            }
            else
            {
                gender = 1;
            }
            bool check = teacherService.update(name, age, school, gender, id);
            if (check)
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
