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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.sName = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.query = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.paperTitle = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.tName = new Sunny.UI.UITextBox();
            this.data = new Sunny.UI.UIDataGridView();
            this.startTime = new Sunny.UI.UIDatePicker();
            this.endTime = new Sunny.UI.UIDatePicker();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLabel4);
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
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            // sName
            // 
            this.sName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sName.Location = new System.Drawing.Point(107, 41);
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
            this.uiLabel1.Location = new System.Drawing.Point(37, 41);
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
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(332, 38);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(130, 27);
            this.uiLabel2.TabIndex = 17;
            this.uiLabel2.Text = "论文题目：";
            // 
            // paperTitle
            // 
            this.paperTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paperTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paperTitle.Location = new System.Drawing.Point(456, 41);
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
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(742, 39);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(91, 29);
            this.uiLabel6.TabIndex = 19;
            this.uiLabel6.Text = "老师：";
            // 
            // tName
            // 
            this.tName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tName.Location = new System.Drawing.Point(825, 41);
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
            // data
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data.BackgroundColor = System.Drawing.Color.White;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle3;
            this.data.EnableHeadersVisualStyles = false;
            this.data.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.data.Location = new System.Drawing.Point(3, 203);
            this.data.Name = "data";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.data.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.data.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.data.RowTemplate.Height = 27;
            this.data.SelectedIndex = -1;
            this.data.Size = new System.Drawing.Size(1220, 292);
            this.data.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.data.TabIndex = 16;
            // 
            // startTime
            // 
            this.startTime.FillColor = System.Drawing.Color.White;
            this.startTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startTime.Location = new System.Drawing.Point(224, 106);
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
            this.startTime.Text = "起始时间";
            this.startTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.startTime.Value = new System.DateTime(2025, 7, 2, 23, 43, 16, 313);
            this.startTime.Watermark = "";
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
            this.endTime.Text = "结尾时间";
            this.endTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.endTime.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.endTime.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(3, 106);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(203, 35);
            this.uiLabel3.TabIndex = 23;
            this.uiLabel3.Text = "发表起始时间：";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(432, 104);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(177, 35);
            this.uiLabel4.TabIndex = 24;
            this.uiLabel4.Text = "发表结尾时间:";
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
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
    }
}