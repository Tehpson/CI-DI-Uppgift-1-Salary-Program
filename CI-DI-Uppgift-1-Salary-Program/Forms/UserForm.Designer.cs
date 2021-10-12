
namespace CI_DI_Uppgift_1_Salary_Program.Forms
{
    partial class UserForm
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
            this.usernameLBL = new System.Windows.Forms.Label();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rolelbl = new System.Windows.Forms.Label();
            this.salarylbl = new System.Windows.Forms.Label();
            this.saldolbl = new System.Windows.Forms.Label();
            this.roleRequestDropdown = new System.Windows.Forms.ComboBox();
            this.RequestRoleBtn = new System.Windows.Forms.Button();
            this.requestSalarytbx = new System.Windows.Forms.TextBox();
            this.RequestSalarybtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLBL
            // 
            this.usernameLBL.AutoSize = true;
            this.usernameLBL.Location = new System.Drawing.Point(12, 9);
            this.usernameLBL.Name = "usernameLBL";
            this.usernameLBL.Size = new System.Drawing.Size(87, 15);
            this.usernameLBL.TabIndex = 0;
            this.usernameLBL.Text = "PLACEHOLDER";
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Location = new System.Drawing.Point(194, 143);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(121, 23);
            this.Logoutbtn.TabIndex = 1;
            this.Logoutbtn.Text = "Logout";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saldo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salary:";
            // 
            // Rolelbl
            // 
            this.Rolelbl.AutoSize = true;
            this.Rolelbl.Location = new System.Drawing.Point(12, 48);
            this.Rolelbl.Name = "Rolelbl";
            this.Rolelbl.Size = new System.Drawing.Size(95, 15);
            this.Rolelbl.TabIndex = 5;
            this.Rolelbl.Text = "Role placeholder";
            // 
            // salarylbl
            // 
            this.salarylbl.AutoSize = true;
            this.salarylbl.Location = new System.Drawing.Point(14, 90);
            this.salarylbl.Name = "salarylbl";
            this.salarylbl.Size = new System.Drawing.Size(102, 15);
            this.salarylbl.TabIndex = 6;
            this.salarylbl.Text = "salary placeholder";
            // 
            // saldolbl
            // 
            this.saldolbl.AutoSize = true;
            this.saldolbl.Location = new System.Drawing.Point(14, 141);
            this.saldolbl.Name = "saldolbl";
            this.saldolbl.Size = new System.Drawing.Size(100, 15);
            this.saldolbl.TabIndex = 7;
            this.saldolbl.Text = "saldo placeholder";
            // 
            // roleRequestDropdown
            // 
            this.roleRequestDropdown.FormattingEnabled = true;
            this.roleRequestDropdown.Location = new System.Drawing.Point(194, 6);
            this.roleRequestDropdown.Name = "roleRequestDropdown";
            this.roleRequestDropdown.Size = new System.Drawing.Size(121, 23);
            this.roleRequestDropdown.TabIndex = 8;
            // 
            // RequestRoleBtn
            // 
            this.RequestRoleBtn.Location = new System.Drawing.Point(194, 33);
            this.RequestRoleBtn.Name = "RequestRoleBtn";
            this.RequestRoleBtn.Size = new System.Drawing.Size(121, 23);
            this.RequestRoleBtn.TabIndex = 9;
            this.RequestRoleBtn.Text = "Request Role";
            this.RequestRoleBtn.UseVisualStyleBackColor = true;
            this.RequestRoleBtn.Click += new System.EventHandler(this.RequestRoleBtn_Click);
            // 
            // requestSalarytbx
            // 
            this.requestSalarytbx.Location = new System.Drawing.Point(194, 62);
            this.requestSalarytbx.Name = "requestSalarytbx";
            this.requestSalarytbx.Size = new System.Drawing.Size(121, 23);
            this.requestSalarytbx.TabIndex = 10;
            // 
            // RequestSalarybtn
            // 
            this.RequestSalarybtn.Location = new System.Drawing.Point(194, 91);
            this.RequestSalarybtn.Name = "RequestSalarybtn";
            this.RequestSalarybtn.Size = new System.Drawing.Size(121, 23);
            this.RequestSalarybtn.TabIndex = 11;
            this.RequestSalarybtn.Text = "Request Salary";
            this.RequestSalarybtn.UseVisualStyleBackColor = true;
            this.RequestSalarybtn.Click += new System.EventHandler(this.RequestSalarybtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Location = new System.Drawing.Point(194, 117);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Delete Account";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 173);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RequestSalarybtn);
            this.Controls.Add(this.requestSalarytbx);
            this.Controls.Add(this.RequestRoleBtn);
            this.Controls.Add(this.roleRequestDropdown);
            this.Controls.Add(this.saldolbl);
            this.Controls.Add(this.salarylbl);
            this.Controls.Add(this.Rolelbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.usernameLBL);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLBL;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Rolelbl;
        private System.Windows.Forms.Label salarylbl;
        private System.Windows.Forms.Label saldolbl;
        private System.Windows.Forms.ComboBox roleRequestDropdown;
        private System.Windows.Forms.Button RequestRoleBtn;
        private System.Windows.Forms.TextBox requestSalarytbx;
        private System.Windows.Forms.Button RequestSalarybtn;
        private System.Windows.Forms.Button button2;
    }
}