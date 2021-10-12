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
        public float Salary { get; set; } = 100;
        public Role Role { get; set; }


        public void AddSalary() => Saldo += Salary;

        public override string ToString() => $"username: {Username}, Password: {Password}, Salary: {Salary}, Saldo: {Saldo}, Role: {Role}";
    }
    public enum Role
    {
        Admin,
        CEO,
        Janitor,
        HR,
        yeeter,
    }}
