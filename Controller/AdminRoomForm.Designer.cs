namespace StudentInfoManageSystem.Controller
{
    partial class AdminRoomForm
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
            this.update = new Sunny.UI.UIButton();
            this.query = new Sunny.UI.UIButton();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.building = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.room = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.roomStatus = new Sunny.UI.UIComboBox();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.roomStatus);
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Controls.Add(this.room);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Controls.Add(this.building);
            this.uiPanel1.Controls.Add(this.uiLabel6);
            this.uiPanel1.Controls.Add(this.update);
            this.uiPanel1.Controls.Add(this.query);
            this.uiPanel1.Font = new System.Drawing.Font("华文彩云", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.ForeColor = System.Drawing.Color.BlueViolet;
            this.uiPanel1.Location = new System.Drawing.Point(0, 35);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1095, 458);
            this.uiPanel1.TabIndex = 16;
            this.uiPanel1.Text = "教室管理";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // update
            // 
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.update.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.update.ForeColor = System.Drawing.Color.Tan;
            this.update.Location = new System.Drawing.Point(170, 354);
            this.update.MinimumSize = new System.Drawing.Size(1, 1);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(230, 68);
            this.update.TabIndex = 19;
            this.update.Text = "修改教室状态";
            this.update.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // query
            // 
            this.query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.query.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query.Location = new System.Drawing.Point(705, 354);
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
            this.uiLabel6.Font = new System.Drawing.Font("华文彩云", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uiLabel6.Location = new System.Drawing.Point(227, 123);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(271, 54);
            this.uiLabel6.TabIndex = 20;
            this.uiLabel6.Text = "教学楼：";
            // 
            // building
            // 
            this.building.DataSource = null;
            this.building.FillColor = System.Drawing.Color.White;
            this.building.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.building.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.building.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.building.Location = new System.Drawing.Point(494, 125);
            this.building.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.building.MinimumSize = new System.Drawing.Size(63, 0);
            this.building.Name = "building";
            this.building.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.building.Size = new System.Drawing.Size(273, 54);
            this.building.SymbolSize = 24;
            this.building.TabIndex = 22;
            this.building.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.building.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("华文中宋", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uiLabel1.Location = new System.Drawing.Point(227, 199);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(173, 70);
            this.uiLabel1.TabIndex = 23;
            this.uiLabel1.Text = "教室:";
            // 
            // room
            // 
            this.room.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.room.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.room.Location = new System.Drawing.Point(494, 209);
            this.room.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.room.MinimumSize = new System.Drawing.Size(1, 16);
            this.room.Name = "room";
            this.room.Padding = new System.Windows.Forms.Padding(5);
            this.room.ShowText = false;
            this.room.Size = new System.Drawing.Size(273, 51);
            this.room.TabIndex = 24;
            this.room.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.room.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("华文中宋", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiLabel2.Location = new System.Drawing.Point(227, 281);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(173, 70);
            this.uiLabel2.TabIndex = 25;
            this.uiLabel2.Text = "状态:";
            // 
            // roomStatus
            // 
            this.roomStatus.DataSource = null;
            this.roomStatus.FillColor = System.Drawing.Color.White;
            this.roomStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roomStatus.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.roomStatus.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.roomStatus.Location = new System.Drawing.Point(494, 281);
            this.roomStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.roomStatus.Name = "roomStatus";
            this.roomStatus.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.roomStatus.Size = new System.Drawing.Size(273, 54);
            this.roomStatus.SymbolSize = 24;
            this.roomStatus.TabIndex = 26;
            this.roomStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomStatus.Watermark = "";
            // 
            // AdminRoomForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1100, 498);
            this.Controls.Add(this.uiPanel1);
            this.Name = "AdminRoomForm";
            this.Text = "AdminRoomForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1100, 498);
            this.Load += new System.EventHandler(this.AdminRoomForm_Load);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton update;
        private Sunny.UI.UIButton query;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboBox building;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox roomStatus;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox room;
    }
}