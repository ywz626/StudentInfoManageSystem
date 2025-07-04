namespace StudentInfoManageSystem.Controller
{
    partial class AdminMajorForm
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
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.schoolId = new Sunny.UI.UITextBox();
            this.majorId = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.major = new Sunny.UI.UIComboBox();
            this.add = new Sunny.UI.UIButton();
            this.delete = new Sunny.UI.UIButton();
            this.update = new Sunny.UI.UIButton();
            this.studentAmount = new Sunny.UI.UITextBox();
            this.school = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.query = new Sunny.UI.UIButton();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLabel5);
            this.uiPanel1.Controls.Add(this.schoolId);
            this.uiPanel1.Controls.Add(this.majorId);
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Controls.Add(this.major);
            this.uiPanel1.Controls.Add(this.add);
            this.uiPanel1.Controls.Add(this.delete);
            this.uiPanel1.Controls.Add(this.update);
            this.uiPanel1.Controls.Add(this.studentAmount);
            this.uiPanel1.Controls.Add(this.school);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Controls.Add(this.uiLabel3);
            this.uiPanel1.Controls.Add(this.query);
            this.uiPanel1.Controls.Add(this.uiLabel6);
            this.uiPanel1.Font = new System.Drawing.Font("华文彩云", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.uiPanel1.Location = new System.Drawing.Point(4, 40);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1236, 493);
            this.uiPanel1.TabIndex = 17;
            this.uiPanel1.Text = "专业管理";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(546, 201);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(232, 66);
            this.uiLabel5.TabIndex = 27;
            this.uiLabel5.Text = "学院编号:";
            // 
            // schoolId
            // 
            this.schoolId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.schoolId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.schoolId.Location = new System.Drawing.Point(779, 214);
            this.schoolId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.schoolId.MinimumSize = new System.Drawing.Size(1, 16);
            this.schoolId.Name = "schoolId";
            this.schoolId.Padding = new System.Windows.Forms.Padding(5);
            this.schoolId.ShowText = false;
            this.schoolId.Size = new System.Drawing.Size(309, 53);
            this.schoolId.TabIndex = 26;
            this.schoolId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.schoolId.Watermark = "";
            // 
            // majorId
            // 
            this.majorId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.majorId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.majorId.Location = new System.Drawing.Point(779, 118);
            this.majorId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.majorId.MinimumSize = new System.Drawing.Size(1, 16);
            this.majorId.Name = "majorId";
            this.majorId.Padding = new System.Windows.Forms.Padding(5);
            this.majorId.ShowText = false;
            this.majorId.Size = new System.Drawing.Size(309, 53);
            this.majorId.TabIndex = 25;
            this.majorId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.majorId.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(546, 113);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(352, 66);
            this.uiLabel2.TabIndex = 23;
            this.uiLabel2.Text = "专业编号:";
            // 
            // major
            // 
            this.major.DataSource = null;
            this.major.FillColor = System.Drawing.Color.White;
            this.major.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.major.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.major.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.major.Location = new System.Drawing.Point(222, 113);
            this.major.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.major.MinimumSize = new System.Drawing.Size(63, 0);
            this.major.Name = "major";
            this.major.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.major.Size = new System.Drawing.Size(294, 58);
            this.major.SymbolSize = 24;
            this.major.TabIndex = 22;
            this.major.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.major.Watermark = "";
            // 
            // add
            // 
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FillColor = System.Drawing.Color.Purple;
            this.add.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add.ForeColor = System.Drawing.Color.SandyBrown;
            this.add.Location = new System.Drawing.Point(52, 386);
            this.add.MinimumSize = new System.Drawing.Size(1, 1);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(178, 68);
            this.add.TabIndex = 21;
            this.add.Text = "添加专业";
            this.add.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete.ForeColor = System.Drawing.Color.Red;
            this.delete.Location = new System.Drawing.Point(357, 386);
            this.delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.delete.Name = "delete";
            this.delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.delete.Size = new System.Drawing.Size(179, 68);
            this.delete.TabIndex = 20;
            this.delete.Text = "删除专业";
            this.delete.TipsColor = System.Drawing.Color.Plum;
            this.delete.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.update.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.update.ForeColor = System.Drawing.Color.Gray;
            this.update.Location = new System.Drawing.Point(649, 386);
            this.update.MinimumSize = new System.Drawing.Size(1, 1);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(183, 68);
            this.update.TabIndex = 19;
            this.update.Text = "修改专业信息";
            this.update.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // studentAmount
            // 
            this.studentAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentAmount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.studentAmount.Location = new System.Drawing.Point(268, 298);
            this.studentAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentAmount.MinimumSize = new System.Drawing.Size(1, 16);
            this.studentAmount.Name = "studentAmount";
            this.studentAmount.Padding = new System.Windows.Forms.Padding(5);
            this.studentAmount.ShowText = false;
            this.studentAmount.Size = new System.Drawing.Size(309, 53);
            this.studentAmount.TabIndex = 18;
            this.studentAmount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentAmount.Watermark = "";
            // 
            // school
            // 
            this.school.DataSource = null;
            this.school.FillColor = System.Drawing.Color.White;
            this.school.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.school.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.school.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.school.Location = new System.Drawing.Point(222, 207);
            this.school.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.school.MinimumSize = new System.Drawing.Size(63, 0);
            this.school.Name = "school";
            this.school.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.school.Size = new System.Drawing.Size(294, 60);
            this.school.SymbolSize = 24;
            this.school.TabIndex = 17;
            this.school.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.school.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(78, 113);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(137, 78);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "专业:";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(78, 207);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(180, 75);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "学院：";
            // 
            // query
            // 
            this.query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.Location = new System.Drawing.Point(979, 386);
            this.query.MinimumSize = new System.Drawing.Size(1, 1);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(183, 68);
            this.query.TabIndex = 8;
            this.query.Text = "查询";
            this.query.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(79, 298);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(361, 68);
            this.uiLabel6.TabIndex = 4;
            this.uiLabel6.Text = "学生人数:";
            // 
            // AdminMajorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1244, 530);
            this.Controls.Add(this.uiPanel1);
            this.Name = "AdminMajorForm";
            this.Text = "AdminMajorForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1085, 476);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton add;
        private Sunny.UI.UIButton delete;
        private Sunny.UI.UIButton update;
        private Sunny.UI.UITextBox studentAmount;
        private Sunny.UI.UIComboBox school;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton query;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboBox major;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox schoolId;
        private Sunny.UI.UITextBox majorId;
    }
}