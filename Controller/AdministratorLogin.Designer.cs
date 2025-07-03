namespace StudentInfoManageSystem.Controller
{
    partial class AdministratorLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.upwd = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(229, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "管理员登陆";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(254, 163);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(397, 30);
            this.uname.TabIndex = 3;
            // 
            // upwd
            // 
            this.upwd.Location = new System.Drawing.Point(254, 257);
            this.upwd.Name = "upwd";
            this.upwd.Size = new System.Drawing.Size(397, 30);
            this.upwd.TabIndex = 4;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.Desktop;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.ForeColor = System.Drawing.Color.Red;
            this.login.Location = new System.Drawing.Point(333, 358);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(167, 39);
            this.login.TabIndex = 5;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // AdministratorLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(902, 488);
            this.Controls.Add(this.login);
            this.Controls.Add(this.upwd);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdministratorLogin";
            this.Text = "AdministratorLogin";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 902, 488);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox upwd;
        private System.Windows.Forms.Button login;
    }
}