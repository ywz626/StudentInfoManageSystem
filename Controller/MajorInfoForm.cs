using StudentInfoManageSystem.Service;
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
using StudentInfoManageSystem.Service.Impl;

namespace StudentInfoManageSystem.Controller
{
    public partial class MajorInfoForm : UIForm
    {
        public MajorService majorService = new MajorServiceImpl();
        public MajorInfoForm()
        {
            InitializeComponent();
        }

        private void MajorInfoForm_Load(object sender, EventArgs e)
        {
            List<string> majors = majorService.getAllMajor();
            foreach (string item in majors)
            {
                major.Items.Add(item);
            }
        }

        private void query_Click(object sender, EventArgs e)
        {
            string majorName = major.Text.Trim();
            DataTable table = majorService.getMajor(majorName);
            data.DataSource = table;
            data.Columns["name"].HeaderText = "专业名";
            data.Columns["studentAmount"].HeaderText = "专业学生人数";
            data.Columns["schoolName"].HeaderText = "所属学院";
        }
    }
}
