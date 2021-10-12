
namespace CI_DI_Uppgift_1_Salary_Program.Forms
{
    partial class AdminForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.saldolbl = new System.Windows.Forms.Label();
            this.salarylbl = new System.Windows.Forms.Label();
            this.Rolelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.usernameLBL = new System.Windows.Forms.Label();
            this.requestList = new System.Windows.Forms.ListBox();
            this.acceptbtn = new System.Windows.Forms.Button();
            this.denybtn = new System.Windows.Forms.Button();
            this.givesalarybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Location = new System.Drawing.Point(420, 104);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Delete Account";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saldolbl
            // 
            this.saldolbl.AutoSize = true;
            this.saldolbl.Location = new System.Drawing.Point(14, 141);
            this.saldolbl.Name = "saldolbl";
            this.saldolbl.Size = new System.Drawing.Size(100, 15);
            this.saldolbl.TabIndex = 20;
            this.saldolbl.Text = "saldo placeholder";
            // 
            // salarylbl
            // 
            this.salarylbl.AutoSize = true;
            this.salarylbl.Location = new System.Drawing.Point(14, 90);
            this.salarylbl.Name = "salarylbl";
            this.salarylbl.Size = new System.Drawing.Size(102, 15);
            this.salarylbl.TabIndex = 19;
            this.salarylbl.Text = "salary placeholder";
            // 
            // Rolelbl
            // 
            this.Rolelbl.AutoSize = true;
            this.Rolelbl.Location = new System.Drawing.Point(12, 48);
            this.Rolelbl.Name = "Rolelbl";
            this.Rolelbl.Size = new System.Drawing.Size(43, 15);
            this.Rolelbl.TabIndex = 18;
            this.Rolelbl.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Salary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Saldo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Role:";
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Location = new System.Drawing.Point(420, 130);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(121, 23);
            this.Logoutbtn.TabIndex = 14;
            this.Logoutbtn.Text = "Logout";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // usernameLBL
            // 
            this.usernameLBL.AutoSize = true;
            this.usernameLBL.Location = new System.Drawing.Point(12, 9);
            this.usernameLBL.Name = "usernameLBL";
            this.usernameLBL.Size = new System.Drawing.Size(46, 15);
            this.usernameLBL.TabIndex = 13;
            this.usernameLBL.Text = "ADMIN";
            // 
            // requestList
            // 
            this.requestList.FormattingEnabled = true;
            this.requestList.ItemHeight = 15;
            this.requestList.Location = new System.Drawing.Point(122, 11);
            this.requestList.Name = "requestList";
            this.requestList.Size = new System.Drawing.Size(419, 79);
            this.requestList.TabIndex = 26;
            // 
            // acceptbtn
            // 
            this.acceptbtn.BackColor = System.Drawing.Color.LawnGreen;
            this.acceptbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptbtn.Location = new System.Drawing.Point(153, 96);
            this.acceptbtn.Name = "acceptbtn";
            this.acceptbtn.Size = new System.Drawing.Size(121, 23);
            this.acceptbtn.TabIndex = 27;
            this.acceptbtn.Text = "Accept";
            this.acceptbtn.UseVisualStyleBackColor = false;
            this.acceptbtn.Click += new System.EventHandler(this.Acceptbtn_Click);
            // 
            // denybtn
            // 
            this.denybtn.BackColor = System.Drawing.Color.DarkRed;
            this.denybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.denybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.denybtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.denybtn.Location = new System.Drawing.Point(277, 96);
            this.denybtn.Margin = new System.Windows.Forms.Padding(0);
            this.denybtn.Name = "denybtn";
            this.denybtn.Size = new System.Drawing.Size(121, 23);
            this.denybtn.TabIndex = 28;
            this.denybtn.Text = "Deny";
            this.denybtn.UseVisualStyleBackColor = false;
            this.denybtn.Click += new System.EventHandler(this.Denybtn_Click);
            // 
            // givesalarybtn
            // 
            this.givesalarybtn.Location = new System.Drawing.Point(153, 133);
            this.givesalarybtn.Name = "givesalarybtn";
            this.givesalarybtn.Size = new System.Drawing.Size(121, 23);
            this.givesalarybtn.TabIndex = 29;
            this.givesalarybtn.Text = "Give Salary";
            this.givesalarybtn.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 160);
            this.Controls.Add(this.givesalarybtn);
            this.Controls.Add(this.denybtn);
            this.Controls.Add(this.acceptbtn);
            this.Controls.Add(this.requestList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saldolbl);
            this.Controls.Add(this.salarylbl);
            this.Controls.Add(this.Rolelbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.usernameLBL);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label saldolbl;
        private System.Windows.Forms.Label salarylbl;
        private System.Windows.Forms.Label Rolelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Label usernameLBL;
        private System.Windows.Forms.ListBox requestList;
        private System.Windows.Forms.Button acceptbtn;
        private System.Windows.Forms.Button denybtn;
        private System.Windows.Forms.Button givesalarybtn;
    }
}