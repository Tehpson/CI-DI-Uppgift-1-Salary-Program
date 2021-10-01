using System;
using System.Collections.Generic;
using System.Text;

namespace CI_DI_Uppgift_1_Salary_Program.Models
{
    class Request
    {
        public User User { get; set; }
    }
    class RequestSalary : Request
    {
        public float Salary { get; set; }
        public RequestSalary(User user,float salary)
        {
            User = user;
            Salary = salary;
        }
    }    
    class RequestRole: Request
    {
        public Role Role { get; set; }
        public RequestRole(User user, Role role)
        {
            User = user;
            Role = role;
        }
    }
}
