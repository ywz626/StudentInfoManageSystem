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

namespace StudentInfoManageSystem.Controller
{
    public partial class StudentLogin : Form
    {
        public StudentService studentService = new StudentServiceImpl();

        public StudentLogin()
        {
            InitializeComponent();
        }

        private void slogin_Click(object sender, EventArgs e)
        {
            bool checkLogin = studentService.login(uname.Text, upwd.Text);
            if (checkLogin)
            {
                MessageBox.Show("登录成功");
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }

        private void administratorLogin_Click(object sender, EventArgs e)
        {
            AdministratorLogin adminLogin = new AdministratorLogin();
            adminLogin.Show();
        }
    }
}
