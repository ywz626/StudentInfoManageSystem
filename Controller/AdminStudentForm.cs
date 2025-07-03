using StudentInfoManageSystem.DAO.PO;
using StudentInfoManageSystem.Service;
using StudentInfoManageSystem.Service.Impl;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StudentInfoManageSystem.Controller
{
    public partial class AdminStudentForm : UIForm
    {
        public MajorService majorService = new MajorServiceImpl();
        public SchoolService schoolService = new SchoolServiceImpl();
        public StudentService studentService = new StudentServiceImpl();

        public AdminStudentForm()
        {
            InitializeComponent();
        }

        private void AdminStudentForm_Load(object sender, EventArgs e)
        {
            sGrade.Items.Add("研一");
            sGrade.Items.Add("研二");
            sGrade.Items.Add("研三");
            List<string> majors = majorService.getAllMajor();
            foreach (string item in majors)
            {
                sMajor.Items.Add(item);
            }
            List<string> schools = schoolService.getAllSchools();
            foreach (string school in schools)
            {
                sSchool.Items.Add(school);
            }
        }

        private void query_Click(object sender, EventArgs e)
        {
            string name = sName.Text.Trim();
            string num = sNum.Text.Trim();
            string grade = sGrade.Text.Trim();
            int gender = -1;
            if (sex0.Checked)
            {
                gender = 0;
            }
            else
            {
                gender = 1;
            }
            string school = sSchool.Text.Trim();
            string age = sAge.Text.Trim();
            string sgrade = sGrade.Text.Trim();
            int? gradeId = null;
            if (sgrade.Equals("研一"))
            {
                gradeId = 1;
            }
            else if (sgrade.Equals("研二"))
            {
                gradeId = 2;
            }
            else if (sgrade.Equals("研三"))
            {
                gradeId = 3;
            }
            QueryStudentInfoForm queryStudentInfoForm = new QueryStudentInfoForm(name,num,grade,gender,school,age,gradeId);
            queryStudentInfoForm.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string sname = sName.Text.Trim();
            string age = sAge.Text.Trim();
            string smajor = sMajor.Text.Trim();
            string sgrade = sGrade.Text.Trim();
            string sNumber = sNum.Text.Trim();
            string school = sSchool.Text.Trim();
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
            if (sgrade.Equals("研一"))
            {
                gradeId = 1;
            }
            else if (sgrade.Equals("研二"))
            {
                gradeId = 2;
            }
            else if (sgrade.Equals("研三"))
            {
                gradeId = 3;
            }
            if (string.IsNullOrEmpty(sname) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(school) || string.IsNullOrEmpty(sNumber) || string.IsNullOrEmpty(sgrade) || string.IsNullOrEmpty(smajor))
            {
                MessageBox.Show("信息不全请重新填写");
                return;
            }
            bool check = studentService.addStudent(sname, age, school, sNumber, gender, sgrade, smajor);
            if (check)
            {
                MessageBox.Show("插入成功！！！");
            }
            else
            {
                MessageBox.Show("插入失败！！！");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string id = sNum.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("请务必填写学号！");
                return;
            }
            DialogResult result = MessageBox.Show("你确定要删除么？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool check = studentService.delete(id);
                if (check)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            else
            {
                return;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            string id = sNum.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("请务必填写学号！");
                return;
            }
            string sname = sName.Text.Trim();
            string age = sAge.Text.Trim();
            string smajor = sMajor.Text.Trim();
            string sgrade = sGrade.Text.Trim();
            string school = sSchool.Text.Trim();
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
            if (sgrade.Equals("研一"))
            {
                gradeId = 1;
            }
            else if (sgrade.Equals("研二"))
            {
                gradeId = 2;
            }
            else if (sgrade.Equals("研三"))
            {
                gradeId = 3;
            }
            bool check = studentService.update(sname,age,smajor,sgrade,id,school,gender);
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
