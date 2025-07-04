namespace StudentInfoManageSystem.Controller
{
    partial class PaperInfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.endTime = new Sunny.UI.UIDatePicker();
            this.startTime = new Sunny.UI.UIDatePicker();
            this.tName = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.paperTitle = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.sName = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.query = new Sunny.UI.UIButton();
            this.data = new Sunny.UI.UIDataGridView();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.paperId = new Sunny.UI.UITextBox();
            this.add = new Sunny.UI.UIButton();
            this.addTime = new Sunny.UI.UIDatePicker();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLabel5);
            this.uiPanel1.Controls.Add(this.addTime);
            this.uiPanel1.Controls.Add(this.add);
            this.uiPanel1.Controls.Add(this.paperId);
            this.uiPanel1.Controls.Add(this.uiLabel4);
            this.uiPanel1.Controls.Add(this.uiLabel7);
            this.uiPanel1.Controls.Add(this.uiLabel3);
            this.uiPanel1.Controls.Add(this.endTime);
            this.uiPanel1.Controls.Add(this.startTime);
            this.uiPanel1.Controls.Add(this.tName);
            this.uiPanel1.Controls.Add(this.uiLabel6);
            this.uiPanel1.Controls.Add(this.paperTitle);
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Controls.Add(this.sName);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Controls.Add(this.query);
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.ForeColor = System.Drawing.Color.Blue;
            this.uiPanel1.Location = new System.Drawing.Point(4, 40);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1213, 271);
            this.uiPanel1.TabIndex = 15;
            this.uiPanel1.Text = "论文查询";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(493, 127);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(40, 23);
            this.uiLabel7.TabIndex = 24;
            this.uiLabel7.Text = "---";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(27, 116);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(276, 51);
            this.uiLabel3.TabIndex = 23;
            this.uiLabel3.Text = "(查询)发表起始时间:";
            // 
            // endTime
            // 
            this.endTime.FillColor = System.Drawing.Color.White;
            this.endTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endTime.Location = new System.Drawing.Point(529, 106);
            this.endTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endTime.MaxLength = 10;
            this.endTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.endTime.Name = "endTime";
            this.endTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.endTime.Size = new System.Drawing.Size(179, 61);
            this.endTime.SymbolDropDown = 61555;
            this.endTime.SymbolNormal = 61555;
            this.endTime.SymbolSize = 24;
            this.endTime.TabIndex = 22;
            this.endTime.Text = "2026-07-01";
            this.endTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.endTime.Value = new System.DateTime(2026, 7, 1, 0, 0, 0, 0);
            this.endTime.Watermark = "";
            // 
            // startTime
            // 
            this.startTime.FillColor = System.Drawing.Color.White;
            this.startTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startTime.Location = new System.Drawing.Point(306, 106);
            this.startTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startTime.MaxLength = 10;
            this.startTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.startTime.Name = "startTime";
            this.startTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.startTime.Size = new System.Drawing.Size(183, 61);
            this.startTime.SymbolDropDown = 61555;
            this.startTime.SymbolNormal = 61555;
            this.startTime.SymbolSize = 24;
            this.startTime.TabIndex = 21;
            this.startTime.Text = "2025-01-02";
            this.startTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.startTime.Value = new System.DateTime(2025, 1, 2, 23, 43, 0, 0);
            this.startTime.Watermark = "";
            // 
            // tName
            // 
            this.tName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tName.Location = new System.Drawing.Point(858, 53);
            this.tName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tName.MinimumSize = new System.Drawing.Size(1, 16);
            this.tName.Name = "tName";
            this.tName.Padding = new System.Windows.Forms.Padding(5);
            this.tName.ShowText = false;
            this.tName.Size = new System.Drawing.Size(280, 39);
            this.tName.TabIndex = 20;
            this.tName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tName.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(727, 53);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(175, 39);
            this.uiLabel6.TabIndex = 19;
            this.uiLabel6.Text = "指导教师：";
            // 
            // paperTitle
            // 
            this.paperTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paperTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paperTitle.Location = new System.Drawing.Point(454, 53);
            this.paperTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paperTitle.MinimumSize = new System.Drawing.Size(1, 16);
            this.paperTitle.Name = "paperTitle";
            this.paperTitle.Padding = new System.Windows.Forms.Padding(5);
            this.paperTitle.ShowText = false;
            this.paperTitle.Size = new System.Drawing.Size(266, 39);
            this.paperTitle.TabIndex = 18;
            this.paperTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.paperTitle.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(317, 53);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(173, 39);
            this.uiLabel2.TabIndex = 17;
            this.uiLabel2.Text = "论文题目：";
            // 
            // sName
            // 
            this.sName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sName.Location = new System.Drawing.Point(120, 53);
            this.sName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sName.MinimumSize = new System.Drawing.Size(1, 16);
            this.sName.Name = "sName";
            this.sName.Padding = new System.Windows.Forms.Padding(5);
            this.sName.ShowText = false;
            this.sName.Size = new System.Drawing.Size(177, 39);
            this.sName.TabIndex = 14;
            this.sName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.sName.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(27, 53);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(114, 39);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "学生：";
            // 
            // query
            // 
            this.query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.Location = new System.Drawing.Point(888, 181);
            this.query.MinimumSize = new System.Drawing.Size(1, 1);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(206, 51);
            this.query.TabIndex = 8;
            this.query.Text = "查询";
            this.query.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // data
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data.BackgroundColor = System.Drawing.Color.White;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle13;
            this.data.EnableHeadersVisualStyles = false;
            this.data.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.data.Location = new System.Drawing.Point(3, 311);
            this.data.Name = "data";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.data.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.data.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.data.RowTemplate.Height = 27;
            this.data.SelectedIndex = -1;
            this.data.Size = new System.Drawing.Size(1220, 204);
            this.data.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.data.TabIndex = 16;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(727, 116);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(173, 39);
            this.uiLabel4.TabIndex = 25;
            this.uiLabel4.Text = "论文编号：";
            // 
            // paperId
            // 
            this.paperId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paperId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paperId.Location = new System.Drawing.Point(858, 118);
            this.paperId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paperId.MinimumSize = new System.Drawing.Size(1, 16);
            this.paperId.Name = "paperId";
            this.paperId.Padding = new System.Windows.Forms.Padding(5);
            this.paperId.ShowText = false;
            this.paperId.Size = new System.Drawing.Size(266, 39);
            this.paperId.TabIndex = 26;
            this.paperId.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.paperId.Watermark = "";
            // 
            // add
            // 
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add.Location = new System.Drawing.Point(33, 181);
            this.add.MinimumSize = new System.Drawing.Size(1, 1);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(206, 51);
            this.add.TabIndex = 27;
            this.add.Text = "提交论文";
            this.add.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // addTime
            // 
            this.addTime.FillColor = System.Drawing.Color.White;
            this.addTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addTime.Location = new System.Drawing.Point(497, 181);
            this.addTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addTime.MaxLength = 10;
            this.addTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.addTime.Name = "addTime";
            this.addTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.addTime.Size = new System.Drawing.Size(183, 51);
            this.addTime.SymbolDropDown = 61555;
            this.addTime.SymbolNormal = 61555;
            this.addTime.SymbolSize = 24;
            this.addTime.TabIndex = 28;
            this.addTime.Text = "2025-01-02";
            this.addTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTime.Value = new System.DateTime(2025, 1, 2, 23, 43, 0, 0);
            this.addTime.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(259, 181);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(218, 51);
            this.uiLabel5.TabIndex = 29;
            this.uiLabel5.Text = "(提交)发表时间:";
            // 
            // PaperInfoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1219, 518);
            this.Controls.Add(this.data);
            this.Controls.Add(this.uiPanel1);
            this.Name = "PaperInfoForm";
            this.Text = "PaperInfoForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITextBox sName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton query;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox paperTitle;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox tName;
        private Sunny.UI.UIDataGridView data;
        private Sunny.UI.UIDatePicker endTime;
        private Sunny.UI.UIDatePicker startTime;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox paperId;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton add;
        private Sunny.UI.UIDatePicker addTime;
        private Sunny.UI.UILabel uiLabel5;
    }
}