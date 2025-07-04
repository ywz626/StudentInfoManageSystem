namespace StudentInfoManageSystem.Controller
{
    partial class StudentMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headLabel = new Sunny.UI.UILabel();
            this.queryTeachers = new Sunny.UI.UIButton();
            this.queryMajors = new Sunny.UI.UIButton();
            this.queryStudents = new Sunny.UI.UIButton();
            this.queryCourse = new Sunny.UI.UIButton();
            this.queryPaper = new Sunny.UI.UIButton();
            this.queryClassRoom = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // headLabel
            // 
            this.headLabel.Font = new System.Drawing.Font("华文琥珀", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headLabel.ForeColor = System.Drawing.Color.Navy;
            this.headLabel.Location = new System.Drawing.Point(207, 41);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(702, 90);
            this.headLabel.TabIndex = 0;
            this.headLabel.Text = "欢迎你";
            // 
            // queryTeachers
            // 
            this.queryTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queryTeachers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.queryTeachers.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryTeachers.ForeColor = System.Drawing.Color.Black;
            this.queryTeachers.Location = new System.Drawing.Point(155, 134);
            this.queryTeachers.MinimumSize = new System.Drawing.Size(1, 1);
            this.queryTeachers.Name = "queryTeachers";
            this.queryTeachers.Size = new System.Drawing.Size(263, 101);
            this.queryTeachers.TabIndex = 1;
            this.queryTeachers.Text = "查询教师信息";
            this.queryTeachers.TipsColor = System.Drawing.Color.Plum;
            this.queryTeachers.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryTeachers.TipsForeColor = System.Drawing.Color.Black;
            this.queryTeachers.Click += new System.EventHandler(this.queryTeachers_Click);
            // 
            // queryMajors
            // 
            this.queryMajors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queryMajors.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.queryMajors.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryMajors.ForeColor = System.Drawing.Color.Black;
            this.queryMajors.Location = new System.Drawing.Point(155, 273);
            this.queryMajors.MinimumSize = new System.Drawing.Size(1, 1);
            this.queryMajors.Name = "queryMajors";
            this.queryMajors.Size = new System.Drawing.Size(263, 93);
            this.queryMajors.TabIndex = 2;
            this.queryMajors.Text = "查询专业信息";
            this.queryMajors.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryMajors.Click += new System.EventHandler(this.queryMajors_Click);
            // 
            // queryStudents
            // 
            this.queryStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queryStudents.FillColor = System.Drawing.Color.Yellow;
            this.queryStudents.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryStudents.ForeColor = System.Drawing.Color.Black;
            this.queryStudents.Location = new System.Drawing.Point(633, 134);
            this.queryStudents.MinimumSize = new System.Drawing.Size(1, 1);
            this.queryStudents.Name = "queryStudents";
            this.queryStudents.Size = new System.Drawing.Size(247, 101);
            this.queryStudents.TabIndex = 3;
            this.queryStudents.Text = "查询学生信息";
            this.queryStudents.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryStudents.Click += new System.EventHandler(this.queryStudents_Click);
            // 
            // queryCourse
            // 
            this.queryCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queryCourse.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryCourse.ForeColor = System.Drawing.Color.Black;
            this.queryCourse.Location = new System.Drawing.Point(633, 273);
            this.queryCourse.MinimumSize = new System.Drawing.Size(1, 1);
            this.queryCourse.Name = "queryCourse";
            this.queryCourse.Size = new System.Drawing.Size(276, 93);
            this.queryCourse.TabIndex = 4;
            this.queryCourse.Text = "查询课程信息及成绩";
            this.queryCourse.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryCourse.Click += new System.EventHandler(this.queryCourse_Click);
            // 
            // queryPaper
            // 
            this.queryPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queryPaper.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.queryPaper.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryPaper.Location = new System.Drawing.Point(155, 413);
            this.queryPaper.MinimumSize = new System.Drawing.Size(1, 1);
            this.queryPaper.Name = "queryPaper";
            this.queryPaper.Size = new System.Drawing.Size(279, 87);
            this.queryPaper.TabIndex = 5;
            this.queryPaper.Text = "查询及上传论文信息";
            this.queryPaper.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryPaper.Click += new System.EventHandler(this.queryPaper_Click);
            // 
            // queryClassRoom
            // 
            this.queryClassRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queryClassRoom.FillColor = System.Drawing.Color.Fuchsia;
            this.queryClassRoom.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryClassRoom.ForeColor = System.Drawing.Color.Black;
            this.queryClassRoom.Location = new System.Drawing.Point(633, 413);
            this.queryClassRoom.MinimumSize = new System.Drawing.Size(1, 1);
            this.queryClassRoom.Name = "queryClassRoom";
            this.queryClassRoom.Size = new System.Drawing.Size(276, 87);
            this.queryClassRoom.TabIndex = 6;
            this.queryClassRoom.Text = "查询及申请教室信息";
            this.queryClassRoom.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryClassRoom.Click += new System.EventHandler(this.queryClassRoom_Click);
            // 
            // StudentMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1071, 543);
            this.Controls.Add(this.queryClassRoom);
            this.Controls.Add(this.queryPaper);
            this.Controls.Add(this.queryCourse);
            this.Controls.Add(this.queryStudents);
            this.Controls.Add(this.queryMajors);
            this.Controls.Add(this.queryTeachers);
            this.Controls.Add(this.headLabel);
            this.Name = "StudentMainForm";
            this.Text = "StudentMainForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1071, 543);
            this.Load += new System.EventHandler(this.StudentMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel headLabel;
        private Sunny.UI.UIButton queryTeachers;
        private Sunny.UI.UIButton queryMajors;
        private Sunny.UI.UIButton queryStudents;
        private Sunny.UI.UIButton queryCourse;
        private Sunny.UI.UIButton queryPaper;
        private Sunny.UI.UIButton queryClassRoom;
    }
}