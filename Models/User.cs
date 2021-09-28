using System;
using System.Collections.Generic;
using System.Text;

namespace CI_DI_Uppgift_1_Salary_Program.Models
{
    class User : Account
    {
        public bool RequestChangeRole(Models.Role role)
        {
            return false;
        }
        public bool RequestSalaryChange(float salary)
        {
            return false;
        }
    }
}
