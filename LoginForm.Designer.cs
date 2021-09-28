namespace CI_DI_Uppgift_1_Salary_Program
{

    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginBtn = new System.Windows.Forms.Button();
            this.UserNameTBX = new System.Windows.Forms.TextBox();
            this.PWDTBX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(12, 88);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(142, 26);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // UserNameTBX
            // 
            this.UserNameTBX.Location = new System.Drawing.Point(12, 12);
            this.UserNameTBX.Name = "UserNameTBX";
            this.UserNameTBX.PlaceholderText = "User Name";
            this.UserNameTBX.Size = new System.Drawing.Size(142, 23);
            this.UserNameTBX.TabIndex = 1;
            // 
            // PWDTBX
            // 
            this.PWDTBX.Location = new System.Drawing.Point(12, 52);
            this.PWDTBX.Name = "PWDTBX";
            this.PWDTBX.PlaceholderText = "Password";
            this.PWDTBX.Size = new System.Drawing.Size(142, 23);
            this.PWDTBX.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 126);
            this.Controls.Add(this.PWDTBX);
            this.Controls.Add(this.UserNameTBX);
            this.Controls.Add(this.LoginBtn);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox UserNameTBX;
        private System.Windows.Forms.TextBox PWDTBX;
    }
}

