using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CI_DI_Uppgift_1_Salary_Program.Models
{
    public class Admin : Account
    {
        public void AscceptRequest(Models.Request request)
        {
            var user = Data.Data.Accounts.Find(x => x == request.User);
            if (request is Models.RequestRole roleitem)
            {
                user.Role = roleitem.Role;
            }
            else if (request is Models.RequestSalary salaryitem)
            {
                user.Salary = salaryitem.Salary;
            }
            Data.Data.Requests.Remove(request);
        }

        public void DenyRequest(Models.Request request)
        {
            Data.Data.Requests.Remove(request);
        }

        public void GiveSalary()
        {
            foreach (var user in Data.Data.Accounts)
            {
                user.AddSalary();
            }
        }
    }
}
