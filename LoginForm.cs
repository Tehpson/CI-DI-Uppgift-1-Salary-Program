namespace CI_DI_Uppgift_1_Salary_Program
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var account = Functions.LoginLogout.Login(UserNameTBX.Text, PWDTBX.Text);
            if (account == null)
            {
                MessageBox.Show("WORONG PASSWORD OR USERNAME");
            }
            else if (account.Role == Models.Role.Admin)
            {
                var frm = new Forms.AdminForm();
                Hide();
                frm.ShowDialog();
            }
            else
            {
                var frm = new Forms.UserForm();
                Hide();
                frm.ShowDialog();
            }
        }
    }
}
