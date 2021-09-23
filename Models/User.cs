using System;
using System.Collections.Generic;
using System.Text;

namespace CI_DI_Uppgift_1_Salary_Program.Models
{
    class User
    {
        public bool IsAdmin { get; set; } = false;
        public string UserName { get; set; }
        public string Password { get; set; }
        public float Saldo { get; set; }
        public float Salary { get; set; }
    }
}
