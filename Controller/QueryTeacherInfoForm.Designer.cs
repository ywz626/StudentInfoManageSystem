namespace StudentInfoManageSystem.Controller
{
    partial class QueryTeacherInfoForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.ageMax = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.school = new Sunny.UI.UIComboBox();
            this.sex1 = new Sunny.UI.UIRadioButton();
            this.sex0 = new Sunny.UI.UIRadioButton();
            this.query = new Sunny.UI.UIButton();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.sex = new Sunny.UI.UILabel();
            this.ageMin = new Sunny.UI.UITextBox();
            this.name = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.studentInfoSystem = new StudentInfoManageSystem.StudentInfoSystem();
            this.studentInfoSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new Sunny.UI.UIDataGridView();
            this.tId = new Sunny.UI.UITextBox();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoSystemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.tId);
            this.uiPanel1.Controls.Add(this.uiLabel6);
            this.uiPanel1.Controls.Add(this.ageMax);
            this.uiPanel1.Controls.Add(this.uiLabel3);
            this.uiPanel1.Controls.Add(this.school);
            this.uiPanel1.Controls.Add(this.sex1);
            this.uiPanel1.Controls.Add(this.sex0);
            this.uiPanel1.Controls.Add(this.query);
            this.uiPanel1.Controls.Add(this.uiLabel4);
            this.uiPanel1.Controls.Add(this.sex);
            this.uiPanel1.Controls.Add(this.ageMin);
            this.uiPanel1.Controls.Add(this.name);
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.ForeColor = System.Drawing.Color.Red;
            this.uiPanel1.Location = new System.Drawing.Point(4, 40);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RadiusSides = Sunny.UI.UICornerRadiusSides.RightBottom;
            this.uiPanel1.Size = new System.Drawing.Size(1152, 164);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = "教师信息查询";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(-1, 114);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(174, 33);
            this.uiLabel6.TabIndex = 13;
            this.uiLabel6.Text = "教师编号:";
            // 
            // ageMax
            // 
            this.ageMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageMax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ageMax.Location = new System.Drawing.Point(502, 111);
            this.ageMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ageMax.MinimumSize = new System.Drawing.Size(1, 16);
            this.ageMax.Name = "ageMax";
            this.ageMax.Padding = new System.Windows.Forms.Padding(5);
            this.ageMax.ShowText = false;
            this.ageMax.Size = new System.Drawing.Size(51, 37);
            this.ageMax.TabIndex = 12;
            this.ageMax.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ageMax.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(455, 125);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(40, 23);
            this.uiLabel3.TabIndex = 11;
            this.uiLabel3.Text = "---";
            // 
            // school
            // 
            this.school.DataSource = null;
            this.school.FillColor = System.Drawing.Color.White;
            this.school.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.school.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.school.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.school.Location = new System.Drawing.Point(685, 51);
            this.school.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.school.MinimumSize = new System.Drawing.Size(63, 0);
            this.school.Name = "school";
            this.school.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.school.Size = new System.Drawing.Size(150, 29);
            this.school.SymbolSize = 24;
            this.school.TabIndex = 10;
            this.school.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.school.Watermark = "";
            // 
            // sex1
            // 
            this.sex1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sex1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sex1.Location = new System.Drawing.Point(475, 51);
            this.sex1.MinimumSize = new System.Drawing.Size(1, 1);
            this.sex1.Name = "sex1";
            this.sex1.Size = new System.Drawing.Size(63, 29);
            this.sex1.TabIndex = 9;
            this.sex1.Text = "女";
            // 
            // sex0
            // 
            this.sex0.Checked = true;
            this.sex0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sex0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sex0.Location = new System.Drawing.Point(395, 51);
            this.sex0.MinimumSize = new System.Drawing.Size(1, 1);
            this.sex0.Name = "sex0";
            this.sex0.Size = new System.Drawing.Size(73, 29);
            this.sex0.TabIndex = 8;
            this.sex0.Text = "男";
            // 
            // query
            // 
            this.query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.Location = new System.Drawing.Point(958, 49);
            this.query.MinimumSize = new System.Drawing.Size(1, 1);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(159, 35);
            this.query.TabIndex = 7;
            this.query.Text = "查询";
            this.query.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(590, 47);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 33);
            this.uiLabel4.TabIndex = 6;
            this.uiLabel4.Text = "学院：";
            // 
            // sex
            // 
            this.sex.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.sex.Location = new System.Drawing.Point(296, 47);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(95, 33);
            this.sex.TabIndex = 5;
            this.sex.Text = "性别：";
            // 
            // ageMin
            // 
            this.ageMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageMin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ageMin.Location = new System.Drawing.Point(395, 114);
            this.ageMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ageMin.MinimumSize = new System.Drawing.Size(1, 16);
            this.ageMin.Name = "ageMin";
            this.ageMin.Padding = new System.Windows.Forms.Padding(5);
            this.ageMin.ShowText = false;
            this.ageMin.Size = new System.Drawing.Size(53, 33);
            this.ageMin.TabIndex = 4;
            this.ageMin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ageMin.Watermark = "";
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(125, 47);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.MinimumSize = new System.Drawing.Size(1, 16);
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(5);
            this.name.ShowText = false;
            this.name.Size = new System.Drawing.Size(150, 38);
            this.name.TabIndex = 3;
            this.name.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.name.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(296, 114);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 33);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "年龄：";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(3, 47);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(152, 42);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "教师姓名：";
            // 
            // studentInfoSystem
            // 
            this.studentInfoSystem.DataSetName = "StudentInfoSystem";
            this.studentInfoSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoSystemBindingSource
            // 
            this.studentInfoSystemBindingSource.DataSource = this.studentInfoSystem;
            this.studentInfoSystemBindingSource.Position = 0;
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
            this.data.Location = new System.Drawing.Point(4, 203);
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
            this.data.Size = new System.Drawing.Size(1153, 378);
            this.data.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.data.TabIndex = 1;
            // 
            // tId
            // 
            this.tId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tId.Location = new System.Drawing.Point(125, 115);
            this.tId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tId.MinimumSize = new System.Drawing.Size(1, 16);
            this.tId.Name = "tId";
            this.tId.Padding = new System.Windows.Forms.Padding(5);
            this.tId.ShowText = false;
            this.tId.Size = new System.Drawing.Size(175, 33);
            this.tId.TabIndex = 19;
            this.tId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tId.Watermark = "";
            // 
            // QueryTeacherInfoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1160, 584);
            this.Controls.Add(this.data);
            this.Controls.Add(this.uiPanel1);
            this.Name = "QueryTeacherInfoForm";
            this.Text = "QueryTeacherInfoForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1129, 526);
            this.Load += new System.EventHandler(this.QueryTeacherInfoForm_Load);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoSystemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox ageMin;
        private Sunny.UI.UITextBox name;
        private Sunny.UI.UIButton query;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel sex;
        private Sunny.UI.UIRadioButton sex1;
        private Sunny.UI.UIRadioButton sex0;
        private Sunny.UI.UIComboBox school;
        private System.Windows.Forms.BindingSource studentInfoSystemBindingSource;
        private StudentInfoSystem studentInfoSystem;
        private Sunny.UI.UIDataGridView data;
        private Sunny.UI.UITextBox ageMax;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox tId;
    }
}