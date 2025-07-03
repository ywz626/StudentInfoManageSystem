using StudentInfoManageSystem.DAO;
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
    public partial class QueryTeacherInfoForm : UIForm
    {

        public SchoolService schoolService = new SchoolServiceImpl();
        public TeacherService teacherService = new TeacherServiceImpl();
        public QueryTeacherInfoForm()
        {
            InitializeComponent();
        }

        public QueryTeacherInfoForm(string name1, string age, string school1, string id, int gender)
        {
            InitializeComponent();
            name.Text = name1;
            ageMin.Text = age;
            school.Text = school1;
            tId.Text = id;
            if(gender == 0)
            {
                sex0.Checked = true;
            }
            else
            {
                sex1.Checked = true;
            }
            query_Click("", new EventArgs());
        }

        private void QueryTeacherInfoForm_Load(object sender, EventArgs e)
        {
            List<string> schools = schoolService.getAllSchools();
            foreach (string item in schools)
            {
                school.Items.Add(item);
            }
        }

        private void query_Click(object sender, EventArgs e)
        {
            string tName = name.Text.Trim();
            string tAgeMin = ageMin.Text.Trim();
            string tAgeMax = ageMax.Text.Trim();
            string tSchool = school.Text.Trim();
            string id = tId.Text.Trim();
            int gender = -1;
            DataTable dataTable;
            if (sex0.Checked)
            {
                gender = 0;
            }
            else
            {
                gender = 1;
            }
            dataTable = teacherService.getTeachers(tName, tAgeMin, tAgeMax, tSchool, gender,id);
            data.DataSource = dataTable;
            data.Columns["name"].HeaderText = "姓名";
            data.Columns["teacherId"].HeaderText = "教师编号";
            data.Columns["age"].HeaderText = "年龄";
            data.Columns["sex"].HeaderText = "性别";
            data.Columns["schoolName"].HeaderText = "所属学院";
        }
    }
}
