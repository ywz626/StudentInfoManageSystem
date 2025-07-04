using HandyControl.Controls;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MessageBox = System.Windows.Forms.MessageBox;
namespace StudentInfoManageSystem.Controller
{
    public partial class AdminMajorForm : UIForm
    {
        public MajorService majorService = new MajorServiceImpl();
        public SchoolService schoolService = new SchoolServiceImpl();
        public AdminMajorForm()
        {
            InitializeComponent();
        }

        private void AdminMajorForm_Load(object sender, EventArgs e)
        {

        }

        private void query_Click(object sender, EventArgs e)
        {
            string majorName = major.Text.Trim();
            string schoolName = school.Text.Trim();
            string mId = majorId.Text.Trim();
            string sId = schoolId.Text.Trim();
            MajorInfoForm majorInfoForm = new MajorInfoForm(majorName, schoolName,mId,sId);
            majorInfoForm.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string majorName = major.Text.Trim();
            string schoolName = school.Text.Trim();
            string mId = majorId.Text.Trim();
            string sId = schoolId.Text.Trim();
            string amount = studentAmount.Text.Trim();

            if (string.IsNullOrEmpty(majorName) || string.IsNullOrEmpty(schoolName) || string.IsNullOrEmpty(mId) || string.IsNullOrEmpty(sId))
            {
                System.Windows.Forms.MessageBox.Show("信息不全请重新填写");
                return;
            }
            bool check = majorService.addMajor(majorName, schoolName, mId, sId,amount);
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
            string id = majorId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("请务必填写专业编号！");
                return;
            }
            DialogResult result = MessageBox.Show("你确定要删除么？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool check = majorService.delete(id);
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
            string id = majorId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("请务必填写专业编号！");
                return;
            }
            string name = major.Text.Trim();
            string amount = studentAmount.Text.Trim();
            bool check = majorService.update(name, amount, id);
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
