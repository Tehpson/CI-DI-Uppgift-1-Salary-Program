using NUnit.Framework;
using CI_DI_Uppgift_1_Salary_Program.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CI_DI_Uppgift_1_Salary_Program.Models.Tests
{
    [TestFixture()]
    public class AccountTests
    {
        [Test()]
        public void AddSalaryTest()
        {
            var user = new User { Username = "Abbehh", Password = "Abbehh1234", Salary = 2500, Saldo = 500 };
            user.AddSalary();
            Assert.AreEqual(3000,user.Saldo);
        }
    }
}