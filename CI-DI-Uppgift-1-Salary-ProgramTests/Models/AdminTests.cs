using NUnit.Framework;
using CI_DI_Uppgift_1_Salary_Program.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CI_DI_Uppgift_1_Salary_Program.Models.Tests
{
    [TestFixture()]
    public class AdminTests
    {
        [Test()]
        public void GiveSalaryTest()
        {
            Data.Data.FillData();
            var admin = new Admin();
            admin.GiveSalary();
            Assert.AreEqual(Data.Data.Accounts[0].Saldo, 100);
            Assert.AreEqual(Data.Data.Accounts[1].Saldo, 100);
        }
    }
}