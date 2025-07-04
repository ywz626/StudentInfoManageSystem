using StudentInfoManageSystem.Models.DTO;
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
    public partial class AdminPaperForm : UIForm
    {
        public PaperService paperService = new PaperServiceImpl();
        public AdminPaperForm()
        {
            InitializeComponent();
        }

        private void query_Click(object sender, EventArgs e)
        {
            string title = paperTitle.Text.Trim();
            string student = paperStudent.Text.Trim();
            string teacher = paperTeacher.Text.Trim();
            string id = paperId.Text.Trim();
            DateTime time = publishTime.Value;
            var paperQuery = new PaperQueryDTO
            {
                title = title,
                student = student,
                teacher = teacher,
                time = time,
                id = id
            };
            PaperInfoForm paperInfoForm = new PaperInfoForm(paperQuery);
            paperInfoForm.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string title = paperTitle.Text.Trim();
            string student = paperStudent.Text.Trim();
            string teacher = paperTeacher.Text.Trim();
            string id = paperId.Text.Trim();
            DateTime time = publishTime.Value;
            if(string.IsNullOrEmpty(title) || string.IsNullOrEmpty(student) || string.IsNullOrEmpty(teacher) || time == null || string.IsNullOrEmpty(id)) {
                MessageBox.Show("请填写完整信息！！");
                return;
            }
            var paperQuery = new PaperQueryDTO
            {
                title = title,
                student = student,
                teacher = teacher,
                time = time,
                id = id
            };
            bool check = paperService.addPaper(paperQuery);
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
            string student = paperStudent.Text.Trim();
            string title = paperTitle.Text.Trim();
            string id = paperId.Text.Trim();
            if ((string.IsNullOrEmpty(student) || string.IsNullOrEmpty(title)) && string.IsNullOrEmpty(id))
            {
                MessageBox.Show("请填写学生姓名和论文题目 或 论文编号");
                return;
            }
            DialogResult result = MessageBox.Show("你确定要删除么？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool check = paperService.delete(student, title,id);
                if (check)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            string id = paperId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("请务必填写论文编号！");
                return;
            }
            string title = paperTitle.Text.Trim();
            string student = paperStudent.Text.Trim();
            string teacher = paperTeacher.Text.Trim();
            DateTime time = publishTime.Value;
            PaperUpdateDTO paperUpdateDTO = new PaperUpdateDTO
            {
                title = title,
                id = id,
                student = student,
                time = time,
                teacher = teacher,
            };
            bool check = paperService.update(paperUpdateDTO);
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
