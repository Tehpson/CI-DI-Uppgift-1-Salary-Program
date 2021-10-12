using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CI_DI_Uppgift_1_Salary_Program.Models
{
    public class Admin : Account
    {
        public static void AscceptRequest(ListBox listBox)
        {
            var user = Data.Data.Accounts.Find(x => x == ((Models.Request)listBox.SelectedItem).User);
            if (listBox.SelectedItem is Models.RequestRole roleitem)
            {
                user.Role = roleitem.Role;
            }
            else if (listBox.SelectedItem is Models.RequestSalary salaryitem)
            {
                user.Salary = salaryitem.Salary;
            }
            Data.Data.Requests.Remove((Models.Request)listBox.SelectedItem);
            UpdateListbox(listBox);
        }

        public static void DenyRequest(ListBox listBox)
        {
            Data.Data.Requests.Remove((Models.Request)listBox.SelectedItem);
            UpdateListbox(listBox);
        }
        private static void UpdateListbox(ListBox listBox)
        {
            listBox.DataSource = null;
            listBox.Items.Clear();
            listBox.DataSource = Data.Data.Requests;
        }

        public static void GiveSalary()
        {
            foreach (var user in Data.Data.Accounts)
            {
                user.AddSalary();
            }
        }
    }
}
