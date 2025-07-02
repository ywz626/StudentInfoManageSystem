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

        }

        private void administratorLogin_Click(object sender, EventArgs e)
        {
            AdministratorLogin adminLogin = new AdministratorLogin();
            adminLogin.Show();
        }
    }
}
