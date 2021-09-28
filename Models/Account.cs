using System;
using System.Collections.Generic;
using System.Text;

namespace CI_DI_Uppgift_1_Salary_Program.Functions
{
    abstract class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Saldo { get; set; }
        public int Salary { get; set; }
        public Role Role { get; set; }

        public Account(string username,string password)
        {
            Username = username;
            Password = password;
        }

        public void AddSalary() => Saldo += Salary;
    }
    enum Role
    {
        Admin,
        CEO,
        Janitor,
        HR,
    }
}
