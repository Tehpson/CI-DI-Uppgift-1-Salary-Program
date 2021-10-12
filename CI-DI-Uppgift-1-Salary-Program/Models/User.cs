using System;
using System.Collections.Generic;
using System.Text;

namespace CI_DI_Uppgift_1_Salary_Program.Models
{
    public class User : Account
    {
        public bool RequestChangeRole(Models.Role role)
        {
            Data.Data.Requests.Add(new RequestRole(this, role));
            return true;
        }
        public bool RequestSalaryChange(float salary)
        {
            Data.Data.Requests.Add(new RequestSalary(this, salary));
            return true;
        }
    }
}
