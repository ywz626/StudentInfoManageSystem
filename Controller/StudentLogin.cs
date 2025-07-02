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
            string name = uname.Text.Trim();
            string number = unumber.Text.Trim();
            bool checkLogin = studentService.login(name, number);
            if (checkLogin)
            {
                MessageBox.Show("登录成功");
                StudentMainForm studentMainForm = new StudentMainForm(name);    
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
    }
}
