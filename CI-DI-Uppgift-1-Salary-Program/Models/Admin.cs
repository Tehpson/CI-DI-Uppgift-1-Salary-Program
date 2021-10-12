using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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

        public bool AddUser(string username, string password, Role role, float salary)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            if(hasNumber.IsMatch(password) && hasLowerChar.IsMatch(password) && hasUpperChar.IsMatch(password))
            {
                Data.Data.Accounts.Add(new Models.User { Username = username, Password = password, Role = role, Salary = salary });
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
