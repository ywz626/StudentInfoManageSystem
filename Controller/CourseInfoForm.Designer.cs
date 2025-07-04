namespace StudentInfoManageSystem.Controller
{
    partial class CourseInfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.query = new Sunny.UI.UIButton();
            this.school = new Sunny.UI.UIComboBox();
            this.courseName = new Sunny.UI.UITextBox();
            this.courseId = new Sunny.UI.UITextBox();
            this.studyScore = new Sunny.UI.UITextBox();
            this.studyHour = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.courseType = new Sunny.UI.UIComboBox();
            this.major = new Sunny.UI.UIComboBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.teacherName = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.sNumber = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.data = new Sunny.UI.UIDataGridView();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.query);
            this.uiPanel1.Controls.Add(this.school);
            this.uiPanel1.Controls.Add(this.courseName);
            this.uiPanel1.Controls.Add(this.courseId);
            this.uiPanel1.Controls.Add(this.studyScore);
            this.uiPanel1.Controls.Add(this.studyHour);
            this.uiPanel1.Controls.Add(this.uiLabel8);
            this.uiPanel1.Controls.Add(this.uiLabel4);
            this.uiPanel1.Controls.Add(this.courseType);
            this.uiPanel1.Controls.Add(this.major);
            this.uiPanel1.Controls.Add(this.uiLabel7);
            this.uiPanel1.Controls.Add(this.uiLabel5);
            this.uiPanel1.Controls.Add(this.teacherName);
            this.uiPanel1.Controls.Add(this.uiLabel3);
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Controls.Add(this.uiLabel9);
            this.uiPanel1.Controls.Add(this.sNumber);
            this.uiPanel1.Controls.Add(this.uiLabel6);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Font = new System.Drawing.Font("华文彩云", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiPanel1.Location = new System.Drawing.Point(4, 40);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1190, 221);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = "课程信息查询";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // query
            // 
            this.query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.Location = new System.Drawing.Point(807, 73);
            this.query.MinimumSize = new System.Drawing.Size(1, 1);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(180, 29);
            this.query.TabIndex = 48;
            this.query.Text = "查询";
            this.query.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // school
            // 
            this.school.DataSource = null;
            this.school.FillColor = System.Drawing.Color.White;
            this.school.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.school.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.school.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.school.Location = new System.Drawing.Point(440, 73);
            this.school.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.school.MinimumSize = new System.Drawing.Size(63, 0);
            this.school.Name = "school";
            this.school.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.school.Size = new System.Drawing.Size(253, 35);
            this.school.SymbolSize = 24;
            this.school.TabIndex = 47;
            this.school.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.school.Watermark = "";
            // 
            // courseName
            // 
            this.courseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.courseName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.courseName.Location = new System.Drawing.Point(165, 73);
            this.courseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courseName.MinimumSize = new System.Drawing.Size(1, 16);
            this.courseName.Name = "courseName";
            this.courseName.Padding = new System.Windows.Forms.Padding(5);
            this.courseName.ShowText = false;
            this.courseName.Size = new System.Drawing.Size(150, 29);
            this.courseName.TabIndex = 46;
            this.courseName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.courseName.Watermark = "";
            // 
            // courseId
            // 
            this.courseId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.courseId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.courseId.Location = new System.Drawing.Point(175, 177);
            this.courseId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courseId.MinimumSize = new System.Drawing.Size(1, 16);
            this.courseId.Name = "courseId";
            this.courseId.Padding = new System.Windows.Forms.Padding(5);
            this.courseId.ShowText = false;
            this.courseId.Size = new System.Drawing.Size(150, 29);
            this.courseId.TabIndex = 45;
            this.courseId.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.courseId.Watermark = "";
            // 
            // studyScore
            // 
            this.studyScore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studyScore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.studyScore.Location = new System.Drawing.Point(609, 118);
            this.studyScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studyScore.MinimumSize = new System.Drawing.Size(1, 16);
            this.studyScore.Name = "studyScore";
            this.studyScore.Padding = new System.Windows.Forms.Padding(5);
            this.studyScore.ShowText = false;
            this.studyScore.Size = new System.Drawing.Size(96, 29);
            this.studyScore.TabIndex = 44;
            this.studyScore.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.studyScore.Watermark = "";
            // 
            // studyHour
            // 
            this.studyHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studyHour.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.studyHour.Location = new System.Drawing.Point(440, 124);
            this.studyHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studyHour.MinimumSize = new System.Drawing.Size(1, 16);
            this.studyHour.Name = "studyHour";
            this.studyHour.Padding = new System.Windows.Forms.Padding(5);
            this.studyHour.ShowText = false;
            this.studyHour.Size = new System.Drawing.Size(88, 29);
            this.studyHour.TabIndex = 43;
            this.studyHour.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.studyHour.Watermark = "";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(535, 118);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(116, 39);
            this.uiLabel8.TabIndex = 42;
            this.uiLabel8.Text = "学分:";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(359, 124);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(116, 39);
            this.uiLabel4.TabIndex = 41;
            this.uiLabel4.Text = "学时:";
            // 
            // courseType
            // 
            this.courseType.DataSource = null;
            this.courseType.FillColor = System.Drawing.Color.White;
            this.courseType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.courseType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.courseType.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.courseType.Location = new System.Drawing.Point(165, 112);
            this.courseType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courseType.MinimumSize = new System.Drawing.Size(63, 0);
            this.courseType.Name = "courseType";
            this.courseType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.courseType.Size = new System.Drawing.Size(180, 39);
            this.courseType.SymbolSize = 24;
            this.courseType.TabIndex = 40;
            this.courseType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseType.Watermark = "";
            // 
            // major
            // 
            this.major.DataSource = null;
            this.major.FillColor = System.Drawing.Color.White;
            this.major.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.major.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.major.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.major.Location = new System.Drawing.Point(807, 114);
            this.major.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.major.MinimumSize = new System.Drawing.Size(63, 0);
            this.major.Name = "major";
            this.major.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.major.Size = new System.Drawing.Size(180, 39);
            this.major.SymbolSize = 24;
            this.major.TabIndex = 39;
            this.major.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.major.Watermark = "";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(719, 118);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(116, 33);
            this.uiLabel7.TabIndex = 38;
            this.uiLabel7.Text = "专业:";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(29, 177);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(153, 39);
            this.uiLabel5.TabIndex = 37;
            this.uiLabel5.Text = "课程编号:";
            // 
            // teacherName
            // 
            this.teacherName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.teacherName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.teacherName.Location = new System.Drawing.Point(422, 173);
            this.teacherName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teacherName.MinimumSize = new System.Drawing.Size(1, 16);
            this.teacherName.Name = "teacherName";
            this.teacherName.Padding = new System.Windows.Forms.Padding(5);
            this.teacherName.ShowText = false;
            this.teacherName.Size = new System.Drawing.Size(248, 33);
            this.teacherName.TabIndex = 36;
            this.teacherName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.teacherName.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(352, 73);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 41);
            this.uiLabel3.TabIndex = 33;
            this.uiLabel3.Text = "学院：";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(332, 173);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(116, 33);
            this.uiLabel2.TabIndex = 34;
            this.uiLabel2.Text = "教师:";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(29, 118);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(140, 33);
            this.uiLabel9.TabIndex = 32;
            this.uiLabel9.Text = "课程类型：";
            // 
            // sNumber
            // 
            this.sNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sNumber.Location = new System.Drawing.Point(807, 173);
            this.sNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sNumber.MinimumSize = new System.Drawing.Size(1, 16);
            this.sNumber.Name = "sNumber";
            this.sNumber.Padding = new System.Windows.Forms.Padding(5);
            this.sNumber.ShowText = false;
            this.sNumber.Size = new System.Drawing.Size(280, 29);
            this.sNumber.TabIndex = 18;
            this.sNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.sNumber.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(677, 173);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(158, 29);
            this.uiLabel6.TabIndex = 17;
            this.uiLabel6.Text = "学号(可选)：";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(30, 75);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(112, 27);
            this.uiLabel1.TabIndex = 16;
            this.uiLabel1.Text = "课程名：";
            // 
            // data
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data.BackgroundColor = System.Drawing.Color.White;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle8;
            this.data.EnableHeadersVisualStyles = false;
            this.data.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.data.Location = new System.Drawing.Point(3, 259);
            this.data.Name = "data";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.data.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.data.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.data.RowTemplate.Height = 27;
            this.data.SelectedIndex = -1;
            this.data.Size = new System.Drawing.Size(1192, 259);
            this.data.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.data.TabIndex = 8;
            // 
            // CourseInfoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1198, 521);
            this.Controls.Add(this.data);
            this.Controls.Add(this.uiPanel1);
            this.Name = "CourseInfoForm";
            this.Text = "CourseInfoForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1198, 521);
            this.Load += new System.EventHandler(this.CourseInfoForm_Load);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox sNumber;
        private Sunny.UI.UIDataGridView data;
        private Sunny.UI.UITextBox courseId;
        private Sunny.UI.UITextBox studyScore;
        private Sunny.UI.UITextBox studyHour;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIComboBox courseType;
        private Sunny.UI.UIComboBox major;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox teacherName;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox courseName;
        private Sunny.UI.UIComboBox school;
        private Sunny.UI.UIButton query;
    }
}