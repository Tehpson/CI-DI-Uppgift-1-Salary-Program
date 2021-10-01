using System;
using System.Collections.Generic;
using System.Text;

namespace CI_DI_Uppgift_1_Salary_Program.Models
{
    public abstract class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public float Saldo { get; set; } = 0;
        public float Salary { get; set; } = 0;
        public Role Role { get; set; }


        public void AddSalary() => Saldo += Salary;
    }
    public enum Role
    {
        Admin,
        CEO,
        Janitor,
        HR,
    }}
