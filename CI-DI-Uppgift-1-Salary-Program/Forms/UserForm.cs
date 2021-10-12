using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CI_DI_Uppgift_1_Salary_Program.Forms
{
    public partial class UserForm : Form
    {
        public LoginForm LoginForm { get; set; }
        private Models.User User { get; set; }
        public UserForm(LoginForm loginForm ,Models.User user)
        {
            InitializeComponent();
            LoginForm = loginForm;
            User = user;

            usernameLBL.Text = user.Username;
            Rolelbl.Text = user.Role.ToString();
            salarylbl.Text = user.Salary.ToString() + " SEK";
            saldolbl.Text = user.Saldo.ToString() + " SEK";

            roleRequestDropdown.DataSource = Enum.GetValues(typeof(Models.Role));
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            this.Close();
        }

        private void RequestRoleBtn_Click(object sender, EventArgs e)
        {
           var res = User.RequestChangeRole((Models.Role)roleRequestDropdown.SelectedItem);
            MessageBox.Show(res ? "You have requested: " + roleRequestDropdown.SelectedItem : "ERROR");
        }

        private void RequestSalarybtn_Click(object sender, EventArgs e)
        {
            if(float.TryParse(requestSalarytbx.Text, out float salaryres))
            {
                var res = User.RequestSalaryChange(salaryres);
                MessageBox.Show(res ? "You have requested: " + salaryres : "ERROR");
            }
            else
            {
                MessageBox.Show("Need to be a number");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var frm = new DeleteForm(User,this);
            frm.Show();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Show();
        }
    }
}
