
namespace CI_DI_Uppgift_1_Salary_Program.Forms
{
    partial class AddUserForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usernametbx = new System.Windows.Forms.TextBox();
            this.passwordtbx = new System.Windows.Forms.TextBox();
            this.salarytbx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // usernametbx
            // 
            this.usernametbx.Location = new System.Drawing.Point(12, 12);
            this.usernametbx.Name = "usernametbx";
            this.usernametbx.PlaceholderText = "Username";
            this.usernametbx.Size = new System.Drawing.Size(100, 23);
            this.usernametbx.TabIndex = 1;
            // 
            // passwordtbx
            // 
            this.passwordtbx.Location = new System.Drawing.Point(12, 42);
            this.passwordtbx.Name = "passwordtbx";
            this.passwordtbx.PlaceholderText = "Password";
            this.passwordtbx.Size = new System.Drawing.Size(100, 23);
            this.passwordtbx.TabIndex = 2;
            // 
            // salarytbx
            // 
            this.salarytbx.Location = new System.Drawing.Point(12, 72);
            this.salarytbx.Name = "salarytbx";
            this.salarytbx.PlaceholderText = "Salary";
            this.salarytbx.Size = new System.Drawing.Size(100, 23);
            this.salarytbx.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(122, 167);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salarytbx);
            this.Controls.Add(this.passwordtbx);
            this.Controls.Add(this.usernametbx);
            this.Controls.Add(this.comboBox1);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddUserForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox usernametbx;
        private System.Windows.Forms.TextBox passwordtbx;
        private System.Windows.Forms.TextBox salarytbx;
        private System.Windows.Forms.Button button1;
    }
}