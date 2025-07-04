namespace StudentInfoManageSystem.Controller
{
    partial class UpdatePwdForm
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
            this.uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            this.uiSmoothLabel2 = new Sunny.UI.UISmoothLabel();
            this.pwdAgain = new Sunny.UI.UITextBox();
            this.pwd = new Sunny.UI.UITextBox();
            this.admin = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiSmoothLabel1
            // 
            this.uiSmoothLabel1.Font = new System.Drawing.Font("幼圆", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSmoothLabel1.Location = new System.Drawing.Point(101, 119);
            this.uiSmoothLabel1.Name = "uiSmoothLabel1";
            this.uiSmoothLabel1.Size = new System.Drawing.Size(110, 33);
            this.uiSmoothLabel1.TabIndex = 12;
            this.uiSmoothLabel1.Text = "新密码:";
            // 
            // uiSmoothLabel2
            // 
            this.uiSmoothLabel2.Font = new System.Drawing.Font("幼圆", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSmoothLabel2.Location = new System.Drawing.Point(101, 200);
            this.uiSmoothLabel2.Name = "uiSmoothLabel2";
            this.uiSmoothLabel2.Size = new System.Drawing.Size(131, 33);
            this.uiSmoothLabel2.TabIndex = 13;
            this.uiSmoothLabel2.Text = "再次输入:";
            // 
            // pwdAgain
            // 
            this.pwdAgain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwdAgain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdAgain.Location = new System.Drawing.Point(239, 195);
            this.pwdAgain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pwdAgain.MinimumSize = new System.Drawing.Size(1, 16);
            this.pwdAgain.Name = "pwdAgain";
            this.pwdAgain.Padding = new System.Windows.Forms.Padding(5);
            this.pwdAgain.ShowText = false;
            this.pwdAgain.Size = new System.Drawing.Size(515, 38);
            this.pwdAgain.TabIndex = 14;
            this.pwdAgain.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.pwdAgain.Watermark = "";
            // 
            // pwd
            // 
            this.pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwd.Location = new System.Drawing.Point(239, 114);
            this.pwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pwd.MinimumSize = new System.Drawing.Size(1, 16);
            this.pwd.Name = "pwd";
            this.pwd.Padding = new System.Windows.Forms.Padding(5);
            this.pwd.ShowText = false;
            this.pwd.Size = new System.Drawing.Size(515, 38);
            this.pwd.TabIndex = 8;
            this.pwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.pwd.Watermark = "";
            // 
            // admin
            // 
            this.admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.admin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.admin.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.admin.Location = new System.Drawing.Point(280, 303);
            this.admin.MinimumSize = new System.Drawing.Size(1, 1);
            this.admin.Name = "admin";
            this.admin.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.admin.RectDisableColor = System.Drawing.Color.Yellow;
            this.admin.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.admin.RectPressColor = System.Drawing.Color.Yellow;
            this.admin.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.admin.Size = new System.Drawing.Size(217, 51);
            this.admin.TabIndex = 15;
            this.admin.Text = "确认";
            this.admin.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // UpdatePwdForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.pwdAgain);
            this.Controls.Add(this.uiSmoothLabel2);
            this.Controls.Add(this.uiSmoothLabel1);
            this.Name = "UpdatePwdForm";
            this.Text = "UpdatePwdForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UISmoothLabel uiSmoothLabel2;
        private Sunny.UI.UITextBox pwdAgain;
        private Sunny.UI.UITextBox pwd;
        private Sunny.UI.UIButton admin;
    }
}