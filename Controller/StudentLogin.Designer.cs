namespace StudentInfoManageSystem.Controller
{
    partial class StudentLogin
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
            this.administratorLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.upwd = new System.Windows.Forms.TextBox();
            this.slogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // administratorLogin
            // 
            this.administratorLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.administratorLogin.Location = new System.Drawing.Point(427, 481);
            this.administratorLogin.Name = "administratorLogin";
            this.administratorLogin.Size = new System.Drawing.Size(144, 53);
            this.administratorLogin.TabIndex = 0;
            this.administratorLogin.Text = "管理员登录";
            this.administratorLogin.UseVisualStyleBackColor = true;
            this.administratorLogin.Click += new System.EventHandler(this.administratorLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正舒体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(201, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 84);
            this.label1.TabIndex = 1;
            this.label1.Text = "研究生管理系统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(281, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(281, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "密码";
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(284, 204);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(473, 25);
            this.uname.TabIndex = 4;
            // 
            // upwd
            // 
            this.upwd.Location = new System.Drawing.Point(284, 284);
            this.upwd.Name = "upwd";
            this.upwd.Size = new System.Drawing.Size(473, 25);
            this.upwd.TabIndex = 5;
            // 
            // slogin
            // 
            this.slogin.Location = new System.Drawing.Point(427, 334);
            this.slogin.Name = "slogin";
            this.slogin.Size = new System.Drawing.Size(144, 44);
            this.slogin.TabIndex = 6;
            this.slogin.Text = "登录";
            this.slogin.UseVisualStyleBackColor = true;
            this.slogin.Click += new System.EventHandler(this.slogin_Click);
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 546);
            this.Controls.Add(this.slogin);
            this.Controls.Add(this.upwd);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.administratorLogin);
            this.Name = "StudentLogin";
            this.Text = "StudentLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button administratorLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox upwd;
        private System.Windows.Forms.Button slogin;
    }
}