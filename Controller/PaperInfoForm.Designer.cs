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
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
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
            this.uiPanel1.Size = new System.Drawing.Size(1213, 167);
            this.uiPanel1.TabIndex = 15;
            this.uiPanel1.Text = "论文查询";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(79, 106);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(203, 35);
            this.uiLabel3.TabIndex = 23;
            this.uiLabel3.Text = "发表起始时间：";
            // 
            // endTime
            // 
            this.endTime.FillColor = System.Drawing.Color.White;
            this.endTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endTime.Location = new System.Drawing.Point(616, 106);
            this.endTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endTime.MaxLength = 10;
            this.endTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.endTime.Name = "endTime";
            this.endTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.endTime.Size = new System.Drawing.Size(152, 29);
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
            this.startTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startTime.Location = new System.Drawing.Point(353, 106);
            this.startTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startTime.MaxLength = 10;
            this.startTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.startTime.Name = "startTime";
            this.startTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.startTime.Size = new System.Drawing.Size(150, 35);
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
            this.tName.Location = new System.Drawing.Point(850, 53);
            this.tName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tName.MinimumSize = new System.Drawing.Size(1, 16);
            this.tName.Name = "tName";
            this.tName.Padding = new System.Windows.Forms.Padding(5);
            this.tName.ShowText = false;
            this.tName.Size = new System.Drawing.Size(280, 29);
            this.tName.TabIndex = 20;
            this.tName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tName.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(743, 53);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(91, 29);
            this.uiLabel6.TabIndex = 19;
            this.uiLabel6.Text = "老师：";
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
            this.paperTitle.Size = new System.Drawing.Size(266, 29);
            this.paperTitle.TabIndex = 18;
            this.paperTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.paperTitle.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(317, 53);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(130, 27);
            this.uiLabel2.TabIndex = 17;
            this.uiLabel2.Text = "论文题目：";
            // 
            // sName
            // 
            this.sName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sName.Location = new System.Drawing.Point(132, 53);
            this.sName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sName.MinimumSize = new System.Drawing.Size(1, 16);
            this.sName.Name = "sName";
            this.sName.Padding = new System.Windows.Forms.Padding(5);
            this.sName.ShowText = false;
            this.sName.Size = new System.Drawing.Size(150, 29);
            this.sName.TabIndex = 14;
            this.sName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.sName.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(11, 53);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(114, 27);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "学生：";
            // 
            // query
            // 
            this.query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.Location = new System.Drawing.Point(905, 106);
            this.query.MinimumSize = new System.Drawing.Size(1, 1);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(159, 35);
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
            this.data.Location = new System.Drawing.Point(3, 203);
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
            this.data.Size = new System.Drawing.Size(1220, 312);
            this.data.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.data.TabIndex = 16;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(531, 113);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(40, 23);
            this.uiLabel7.TabIndex = 24;
            this.uiLabel7.Text = "---";
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
    }
}