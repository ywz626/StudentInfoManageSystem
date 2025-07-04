using StudentInfoManageSystem.DAO.PO;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StudentInfoManageSystem.Controller
{
    public partial class CourseInfoForm : UIForm
    {
        public MajorService majorService = new MajorServiceImpl();
        public SchoolService schoolService = new SchoolServiceImpl();
        public CourseService courseService = new CourseServiceImpl();
        public CourseInfoForm()
        {
            InitializeComponent();
        }

        public CourseInfoForm(CourseQueryDTO queryParams)
        {
            int? typeId = null;
            InitializeComponent();
            courseName.Text = queryParams.Name.Trim();
            major.Text = queryParams.MajorName.Trim();
            school.Text = queryParams.SchoolName.Trim();
            typeId = queryParams.CourseTypeName;
            studyHour.Text = queryParams.StudyHour;
            studyScore.Text = queryParams.StudyScore;
            sNumber.Text = queryParams.StudentNumber;
            courseId.Text = queryParams.CourseId.Trim();
            teacherName.Text = queryParams.TeacherName;
            if(typeId.HasValue)
            {
                if (typeId.Value == 0)
                {
                    courseType.Text = "通识课";
                }
                else if (typeId.Value == 1)
                {
                    courseType.Text = "专业课";
                }
            }
            query_Click(null, null);
        }

        private void query_Click(object sender, EventArgs e)
        {
            string type = courseType.Text.Trim();
            int? typeId = null;
            if (!string.IsNullOrEmpty(type))
            {
                 typeId = 0;
                if (type == "通识课")
                {
                    typeId = 0;
                }
                else if (type == "专业课")
                {
                    typeId = 1;
                }
            }

            var queryParams = new CourseQueryDTO
            {
                Name = courseName.Text.Trim(),
                MajorName = major.Text.Trim(),
                SchoolName = school.Text.Trim(),
                CourseTypeName = typeId,
                StudyHour = studyHour.Text.Trim(),
                StudyScore = studyScore.Text.Trim(),
                StudentNumber = sNumber.Text.Trim(),
                CourseId = courseId.Text.Trim(),
                TeacherName = teacherName.Text.Trim()
            };
            DataTable dataTable = courseService.getCourse(queryParams);
            data.DataSource = dataTable;
            data.Columns["name"].HeaderText = "课程";
            data.Columns["hours"].HeaderText = "学时";
            data.Columns["credit"].HeaderText = "学分";
            data.Columns["teacherName"].HeaderText = "老师";
            data.Columns["general"].HeaderText = "课程类别";
            data.Columns["schoolName"].HeaderText = "所属学院";
            data.Columns["majorName"].HeaderText = "所属专业";
            data.Columns["status"].HeaderText = "状态";
            if (!string.IsNullOrEmpty(sNumber.Text))
            {
                data.Columns["score"].HeaderText = "成绩";
                data.Columns["studentName"].HeaderText = "学生";
            }
        }

        private void CourseInfoForm_Load(object sender, EventArgs e)
        {
            List<string> majors = majorService.getAllMajor();
            foreach (string item in majors)
            {
                major.Items.Add(item);
            }
            List<string> schools = schoolService.getAllSchools();
            foreach (string item in schools)
            {
                school.Items.Add(item);
            }
            courseType.Items.Add("通识课");
            courseType.Items.Add("专业课");
        }
    }
}
