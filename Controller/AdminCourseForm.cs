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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StudentInfoManageSystem.Controller
{
    public partial class AdminCourseForm : UIForm
    {
        public MajorService majorService = new MajorServiceImpl();
        public SchoolService schoolService = new SchoolServiceImpl();
        public CourseService courseService = new CourseServiceImpl();
        public AdminCourseForm()
        {
            InitializeComponent();
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
                SchoolName = schoolName.Text.Trim(),
                CourseTypeName = typeId,
                StudyHour = studyHour.Text.Trim(),
                StudyScore = studyScore.Text.Trim(),
                CourseId = courseId.Text.Trim(),
                TeacherName = teacherName.Text.Trim()
            };
            CourseInfoForm courseInfoForm = new CourseInfoForm(queryParams);
            courseInfoForm.Show();
        }

        private void AdminCourseForm_Load(object sender, EventArgs e)
        {
            List<string> majors = majorService.getAllMajor();
            foreach (string item in majors)
            {
                major.Items.Add(item);
            }
            List<string> schools = schoolService.getAllSchools();
            foreach (string school in schools)
            {
                schoolName.Items.Add(school);
            }
            courseType.Items.Add("通识课");
            courseType.Items.Add("专业课");
        }

        private void add_Click(object sender, EventArgs e)
        {
            string Name = courseName.Text.Trim();
            string MajorName = major.Text.Trim();
            string SchoolName = schoolName.Text.Trim();
            string StudyHour = studyHour.Text.Trim();
            string StudyScore = studyScore.Text.Trim();
            string CourseId = courseId.Text.Trim();
            string TeacherName = teacherName.Text.Trim();
            string type = courseType.Text.Trim();
            if (string.IsNullOrEmpty(Name) ||
                string.IsNullOrEmpty(MajorName) ||
                string.IsNullOrEmpty(SchoolName) ||
                string.IsNullOrEmpty(type) ||
                string.IsNullOrEmpty(StudyHour) ||
                string.IsNullOrEmpty(StudyScore) ||
                string.IsNullOrEmpty(CourseId) ||
                string.IsNullOrEmpty(TeacherName))
            {
                MessageBox.Show("请填写完整信息");
                return;
            }
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
                SchoolName = schoolName.Text.Trim(),
                CourseTypeName = typeId,
                StudyHour = studyHour.Text.Trim(),
                StudyScore = studyScore.Text.Trim(),
                CourseId = courseId.Text.Trim(),
                TeacherName = teacherName.Text.Trim()
            };
            bool check = courseService.addCourse(queryParams);
            if (check)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败，请检查信息是否正确");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string id = courseId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("请务必填写课程编号！");
                return;
            }
            DialogResult result = MessageBox.Show("你确定要删除么？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool check = courseService.delete(id);
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
            string id = courseId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("请务必填写课程编号！");
                return;
            }
            string Name = courseName.Text.Trim();
            string MajorName = major.Text.Trim();
            string SchoolName = schoolName.Text.Trim();
            string StudyHour = studyHour.Text.Trim();
            string StudyScore = studyScore.Text.Trim();
            string CourseId = courseId.Text.Trim();
            string TeacherName = teacherName.Text.Trim();
            string type = courseType.Text.Trim();
            int? typeId = null;
            if (!string.IsNullOrEmpty(type))
            {
                if (type == "通识课")
                {
                    typeId = 0;
                }
                else if (type == "专业课")
                {
                    typeId = 1;
                }
            }
            var dto = new CourseQueryDTO
            {
                Name = Name,
                MajorName = MajorName,
                SchoolName = SchoolName,
                CourseTypeName = typeId,
                StudyHour = StudyHour,
                StudyScore = StudyScore,
                CourseId = CourseId,
                TeacherName = TeacherName
            };
            bool check = courseService.update(dto);
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
