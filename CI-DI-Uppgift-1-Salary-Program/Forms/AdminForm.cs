using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CI_DI_Uppgift_1_Salary_Program.Forms
{
    public partial class AdminForm : Form
    {
        public LoginForm LoginForm { get; set; }
        public AdminForm(Models.Admin admin, LoginForm loginForm)
        {
            InitializeComponent();
            requestList.DataSource = Data.Data.Requests;
            LoginForm = loginForm;
            salarylbl.Text = admin.Salary.ToString() + "SEK";
            saldolbl.Text = admin.Salary.ToString() + "SEK";

        }

        private void Acceptbtn_Click(object sender, EventArgs e)
        {
            //var item = Data.Data.Requests.Find();
            var user = Data.Data.Accounts.Find(x => x == ((Models.Request)requestList.SelectedItem).User);
            if (requestList.SelectedItem is Models.RequestRole roleitem)
            {
                user.Role = roleitem.Role;
            }
            else if (requestList.SelectedItem is Models.RequestSalary salaryitem)
            {
                user.Salary = salaryitem.Salary;
            }
            Data.Data.Requests.Remove((Models.Request)requestList.SelectedItem);
            requestList.DataSource = null;
            requestList.Items.Clear();
            requestList.DataSource = Data.Data.Requests;
        }

        private void Denybtn_Click(object sender, EventArgs e)
        {
            Data.Data.Requests.Remove((Models.Request)requestList.SelectedItem);
            requestList.DataSource = null;
            requestList.Items.Clear();
            requestList.DataSource = Data.Data.Requests;
        }
        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new Forms.DeleteAdminForm();
            frm.Show();
        }
    }
}
