
namespace CI_DI_Uppgift_1_Salary_Program.Forms
{
    partial class DeleteForm
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
            this.PWDTBX = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PWDTBX
            // 
            this.PWDTBX.Location = new System.Drawing.Point(12, 12);
            this.PWDTBX.Name = "PWDTBX";
            this.PWDTBX.PasswordChar = '*';
            this.PWDTBX.PlaceholderText = "Password";
            this.PWDTBX.Size = new System.Drawing.Size(142, 23);
            this.PWDTBX.TabIndex = 5;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteBtn.Location = new System.Drawing.Point(12, 41);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(142, 26);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete Account ";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 77);
            this.Controls.Add(this.PWDTBX);
            this.Controls.Add(this.DeleteBtn);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PWDTBX;
        private System.Windows.Forms.Button DeleteBtn;
    }
}