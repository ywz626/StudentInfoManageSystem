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
using StudentInfoManageSystem.Models.DTO;
using StudentInfoManageSystem.Utils;

namespace StudentInfoManageSystem.Controller
{
    public partial class PaperInfoForm : UIForm
    {
        public PaperService paperService = new PaperServiceImpl();
        public PaperInfoForm()
        {
            InitializeComponent();
        }

        public PaperInfoForm(PaperQueryDTO paperQuery)
        {
            InitializeComponent();
            sName.Text = paperQuery.student;
            tName.Text = paperQuery.teacher;
            startTime.Value = paperQuery.time;
            endTime.Value = paperQuery.time;
            paperTitle.Text = paperQuery.title;
            paperId.Text = paperQuery.id;
            query_Click(null,null);
        }

        private void query_Click(object sender, EventArgs e)
        {
            string studentName = sName.Text.Trim();
            string teacherName = tName.Text.Trim();
            string title = paperTitle.Text.Trim();
            DateTime sTime = startTime.Value;
            DateTime eTime = endTime.Value;
            string id = paperId.Text.Trim();
            DataTable dataTable = paperService.getPapers(studentName, teacherName, title,sTime,eTime,id);
            data.DataSource = dataTable;
        }

        private void add_Click(object sender, EventArgs e)
        {
            string studentName = sName.Text.Trim();
            string name = CurrentUser.name;
            if (!string.IsNullOrEmpty(studentName)&&studentName!=name)
            {
                MessageBox.Show("您只可以提交您自己的论文哦···");
                return;
            }
            string teacherName = tName.Text.Trim();
            string title = paperTitle.Text.Trim();
            DateTime time = addTime.Value;
            string id = paperId.Text.Trim();
            if (string.IsNullOrEmpty(teacherName) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(id) || time == null)
            {
                MessageBox.Show("请填写必要信息！");
                return;
            }
            PaperQueryDTO paperQueryDTO = new PaperQueryDTO
            {
                title = title,
                time = time,
                teacher = teacherName,
                student = name,
                id = id
            };
            bool check = paperService.addPaper(paperQueryDTO);
            if (check)
            {
                MessageBox.Show("提交成功！！！");
            }
            else
            {
                MessageBox.Show("提交失败！！！");
            }
        }
    }
}
