using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CI_DI_Uppgift_1_Salary_Program.Forms
{
    public partial class AddUserForm : Form
    {
        private Models.Admin Admin;
        private ListBox Listbox;
        public AddUserForm(Models.Admin admin, ListBox listbox)
        {
            InitializeComponent();
            Admin = admin;
            comboBox1.DataSource = Enum.GetValues(typeof(Models.Role));
            Listbox = listbox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(salarytbx.Text, out float result))
            {
                if(Admin.AddUser(usernametbx.Text, passwordtbx.Text, (Models.Role)comboBox1.SelectedItem, result))
                {
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erroe something was wrong");
                }
            }
            else
            {
                MessageBox.Show("Salary need to be a number");
            }
        }

        private void AddUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Listbox.DataSource = null;
            Listbox.Items.Clear();
            Listbox.DataSource = Data.Data.Requests;
        }
    }
}
