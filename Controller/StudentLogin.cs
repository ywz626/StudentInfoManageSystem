using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInfoManageSystem.Service.Impl;
using StudentInfoManageSystem.Service;
using Sunny.UI;
using StudentInfoManageSystem.Utils;
using StudentInfoManageSystem.Models.DTO;

namespace StudentInfoManageSystem.Controller
{
    public partial class StudentLogin : UIForm
    {
        public StudentService studentService = new StudentServiceImpl();

        public StudentLogin()
        {
            InitializeComponent();
        }


        private void student_Click(object sender, EventArgs e)
        {
            string pwd = upwd.Text.Trim();
            string number = unumber.Text.Trim();
            if (string.IsNullOrEmpty(pwd) || string.IsNullOrEmpty(number)) {
                MessageBox.Show("请输入用户名和密码！");
                return;
            }
            StudentLoginDTO student = new StudentLoginDTO
            {
                pwd = pwd,
                sNumber = number,
            };
            string checkLogin = studentService.login(student);
            if (checkLogin != null)
            {
                MessageBox.Show("登录成功");
                CurrentUser.studentNumber = number;
                CurrentUser.name = checkLogin;
                StudentMainForm studentMainForm = new StudentMainForm(checkLogin);    
                studentMainForm.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }

        private void administrator_Click(object sender, EventArgs e)
        {
            AdministratorLogin adminLogin = new AdministratorLogin();
            adminLogin.Show();
        }

        private void forget_Click(object sender, EventArgs e)
        {
            string studentNumber = CurrentUser.studentNumber;
            if (string.IsNullOrEmpty(studentNumber))
            {
                MessageBox.Show("请先登录！！如忘记密码请联系管理员！");
            }
            UpdatePwdForm from = new UpdatePwdForm();
            from.Show();
        }
    }
}
