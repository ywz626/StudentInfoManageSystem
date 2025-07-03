using StudentInfoManageSystem.DAO.PO;
using StudentInfoManageSystem.Service;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoManageSystem.Controller
{
    public partial class AdministratorLogin : UIForm
    {
        string connStr = "Data Source=localhost;Initial Catalog=StudentInfoSystem;Integrated Security=True";
        public AdministratorLogin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string name = uname.Text.Trim();
            string pwd = upwd.Text.Trim();
            bool checkLogin;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "select name from Administrators where name = @name and pwd = @pwd";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        checkLogin = true;
                    }
                    else
                    {
                        checkLogin = false;
                    }
                }
            }
            if (checkLogin)
            {
                MessageBox.Show("登录成功");
                AdminMainForm adminMainForm = new AdminMainForm();
                adminMainForm.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }
    }
}
