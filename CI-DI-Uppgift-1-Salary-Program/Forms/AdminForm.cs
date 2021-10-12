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
        public Models.Admin Admin { get; set; }
        public AdminForm(Models.Admin admin, LoginForm loginForm)
        {
            InitializeComponent();
            requestList.DataSource = Data.Data.Requests;
            LoginForm = loginForm;
            salarylbl.Text = admin.Salary.ToString() + "SEK";
            saldolbl.Text = admin.Salary.ToString() + "SEK";
            Admin = admin;

        }

        private static void UpdateListbox(ListBox listBox)
        {
            listBox.DataSource = null;
            listBox.Items.Clear();
            listBox.DataSource = Data.Data.Requests;
        }

        private void Acceptbtn_Click(object sender, EventArgs e)
        {
            Admin.AscceptRequest((Models.Request)requestList.SelectedItem);

            UpdateListbox(requestList);
        }


        private void Denybtn_Click(object sender, EventArgs e)
        {
            Admin.DenyRequest((Models.Request)requestList.SelectedItem);
            UpdateListbox(requestList);
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var frm = new Forms.DeleteAdminForm();
            frm.Show();
        }

        private void givesalarybtn_Click(object sender, EventArgs e)
        {
            Admin.GiveSalary();
        }
    }
}
