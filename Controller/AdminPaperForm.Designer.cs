namespace StudentInfoManageSystem.Controller
{
    partial class AdminPaperForm
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
            this.paper = new Sunny.UI.UIPanel();
            this.paperId = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.paperTitle = new Sunny.UI.UITextBox();
            this.publishTime = new Sunny.UI.UIDatePicker();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.paperTeacher = new Sunny.UI.UITextBox();
            this.paperStudent = new Sunny.UI.UITextBox();
            this.uuuu = new Sunny.UI.UILabel();
            this.add = new Sunny.UI.UIButton();
            this.delete = new Sunny.UI.UIButton();
            this.update = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.query = new Sunny.UI.UIButton();
            this.paper.SuspendLayout();
            this.SuspendLayout();
            // 
            // paper
            // 
            this.paper.Controls.Add(this.paperId);
            this.paper.Controls.Add(this.uiLabel2);
            this.paper.Controls.Add(this.paperTitle);
            this.paper.Controls.Add(this.publishTime);
            this.paper.Controls.Add(this.uiLabel5);
            this.paper.Controls.Add(this.paperTeacher);
            this.paper.Controls.Add(this.paperStudent);
            this.paper.Controls.Add(this.uuuu);
            this.paper.Controls.Add(this.add);
            this.paper.Controls.Add(this.delete);
            this.paper.Controls.Add(this.update);
            this.paper.Controls.Add(this.uiLabel1);
            this.paper.Controls.Add(this.uiLabel3);
            this.paper.Controls.Add(this.query);
            this.paper.Font = new System.Drawing.Font("华文彩云", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paper.ForeColor = System.Drawing.Color.Blue;
            this.paper.Location = new System.Drawing.Point(4, 40);
            this.paper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paper.MinimumSize = new System.Drawing.Size(1, 1);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(1236, 493);
            this.paper.TabIndex = 18;
            this.paper.Text = "论文管理";
            this.paper.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // paperId
            // 
            this.paperId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paperId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paperId.Location = new System.Drawing.Point(297, 218);
            this.paperId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paperId.MinimumSize = new System.Drawing.Size(1, 16);
            this.paperId.Name = "paperId";
            this.paperId.Padding = new System.Windows.Forms.Padding(5);
            this.paperId.ShowText = false;
            this.paperId.Size = new System.Drawing.Size(234, 58);
            this.paperId.TabIndex = 31;
            this.paperId.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.paperId.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(78, 210);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(251, 78);
            this.uiLabel2.TabIndex = 30;
            this.uiLabel2.Text = "论文编号:";
            // 
            // paperTitle
            // 
            this.paperTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paperTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paperTitle.Location = new System.Drawing.Point(222, 113);
            this.paperTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paperTitle.MinimumSize = new System.Drawing.Size(1, 16);
            this.paperTitle.Name = "paperTitle";
            this.paperTitle.Padding = new System.Windows.Forms.Padding(5);
            this.paperTitle.ShowText = false;
            this.paperTitle.Size = new System.Drawing.Size(309, 58);
            this.paperTitle.TabIndex = 29;
            this.paperTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.paperTitle.Watermark = "";
            // 
            // publishTime
            // 
            this.publishTime.FillColor = System.Drawing.Color.White;
            this.publishTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.publishTime.Location = new System.Drawing.Point(811, 113);
            this.publishTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.publishTime.MaxLength = 10;
            this.publishTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.publishTime.Name = "publishTime";
            this.publishTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.publishTime.Size = new System.Drawing.Size(180, 58);
            this.publishTime.SymbolDropDown = 61555;
            this.publishTime.SymbolNormal = 61555;
            this.publishTime.SymbolSize = 24;
            this.publishTime.TabIndex = 28;
            this.publishTime.Text = "2025-01-02";
            this.publishTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.publishTime.Value = new System.DateTime(2025, 1, 2, 23, 43, 0, 0);
            this.publishTime.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(559, 210);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(232, 66);
            this.uiLabel5.TabIndex = 27;
            this.uiLabel5.Text = "指导教师:";
            // 
            // paperTeacher
            // 
            this.paperTeacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paperTeacher.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paperTeacher.Location = new System.Drawing.Point(811, 210);
            this.paperTeacher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paperTeacher.MinimumSize = new System.Drawing.Size(1, 16);
            this.paperTeacher.Name = "paperTeacher";
            this.paperTeacher.Padding = new System.Windows.Forms.Padding(5);
            this.paperTeacher.ShowText = false;
            this.paperTeacher.Size = new System.Drawing.Size(309, 53);
            this.paperTeacher.TabIndex = 26;
            this.paperTeacher.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.paperTeacher.Watermark = "";
            // 
            // paperStudent
            // 
            this.paperStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paperStudent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paperStudent.Location = new System.Drawing.Point(222, 314);
            this.paperStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paperStudent.MinimumSize = new System.Drawing.Size(1, 16);
            this.paperStudent.Name = "paperStudent";
            this.paperStudent.Padding = new System.Windows.Forms.Padding(5);
            this.paperStudent.ShowText = false;
            this.paperStudent.Size = new System.Drawing.Size(309, 53);
            this.paperStudent.TabIndex = 25;
            this.paperStudent.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.paperStudent.Watermark = "";
            // 
            // uuuu
            // 
            this.uuuu.Font = new System.Drawing.Font("微软雅黑", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uuuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uuuu.Location = new System.Drawing.Point(78, 301);
            this.uuuu.Name = "uuuu";
            this.uuuu.Size = new System.Drawing.Size(169, 66);
            this.uuuu.TabIndex = 23;
            this.uuuu.Text = "学生:";
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
            this.add.Text = "增加";
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
            this.delete.Text = "删除";
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
            this.update.Text = "修改";
            this.update.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(78, 113);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(137, 78);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "题目:";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(559, 113);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(287, 78);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "发布时间：";
            // 
            // query
            // 
            this.query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.Location = new System.Drawing.Point(980, 386);
            this.query.MinimumSize = new System.Drawing.Size(1, 1);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(183, 68);
            this.query.TabIndex = 8;
            this.query.Text = "查询";
            this.query.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // AdminPaperForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1244, 536);
            this.Controls.Add(this.paper);
            this.Name = "AdminPaperForm";
            this.Text = "AdminPaperForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1090, 522);
            this.paper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel paper;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox paperTeacher;
        private Sunny.UI.UITextBox paperStudent;
        private Sunny.UI.UILabel uuuu;
        private Sunny.UI.UIButton add;
        private Sunny.UI.UIButton delete;
        private Sunny.UI.UIButton update;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton query;
        private Sunny.UI.UIDatePicker publishTime;
        private Sunny.UI.UITextBox paperTitle;
        private Sunny.UI.UITextBox paperId;
        private Sunny.UI.UILabel uiLabel2;
    }
}