using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CI_DI_Uppgift_1_Salary_Program.Forms
{
    public partial class DeleteAdminForm : Form
    { 
        public DeleteAdminForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            if(Functions.LoginLogout.DeleteAccountAdmin(UserNameTBX.Text, PWDTBX.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong credentatlas");
            }
        }
    }
}
