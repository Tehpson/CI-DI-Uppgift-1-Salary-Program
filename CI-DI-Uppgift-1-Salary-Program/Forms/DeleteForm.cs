using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CI_DI_Uppgift_1_Salary_Program.Forms
{
    public partial class DeleteForm : Form
    {
        private Models.User User;
        private UserForm UserForm;
        public DeleteForm(Models.User user, UserForm userForm)
        {
            InitializeComponent();
            User = user;
            UserForm = userForm;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Functions.LoginLogout.DeleteAccountUser(User, PWDTBX.Text);
            UserForm.Close();
            this.Close();
        }
    }
}
