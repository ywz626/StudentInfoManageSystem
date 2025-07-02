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
    public partial class PaperInfoForm : UIForm
    {
        public PaperService paperService = new PaperServiceImpl();
        public PaperInfoForm()
        {
            InitializeComponent();
        }

        private void query_Click(object sender, EventArgs e)
        {
            string studentName = sName.Text.Trim();
            string teacherName = tName.Text.Trim();
            string title = paperTitle.Text.Trim();
            DateTime sTime = startTime.Value;
            DateTime eTime = endTime.Value;
            DataTable dataTable = paperService.getPapers(studentName, teacherName, title,sTime,eTime);
            data.DataSource = dataTable;
        }
    }
}
