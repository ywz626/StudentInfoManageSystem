using StudentInfoManageSystem.Service;
using StudentInfoManageSystem.Service.Impl;
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
    public partial class UpdatePwdForm : UIForm
    {
        public StudentService studentService = new StudentServiceImpl();
        public UpdatePwdForm()
        {
            InitializeComponent();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            string newpwd = pwd.Text;
            string newpwdAgain = pwdAgain.Text;
            if(newpwd != newpwdAgain)
            {
                MessageBox.Show("两次输入的密码不相同，重新输入");
                return;
            }
            bool check = studentService.updatePwd(newpwd);
            if (check)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }
    }
}
