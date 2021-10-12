using NUnit.Framework;
using CI_DI_Uppgift_1_Salary_Program;
using System;
using System.Collections.Generic;
using System.Text;

namespace CI_DI_Uppgift_1_Salary_ProgramTests
{
    [TestFixture()]
    public class IntegrationTest
    {
        [Test()]
        public void intergrationtest1()
        {
            CI_DI_Uppgift_1_Salary_Program.Data.Data.Accounts.Clear();
            CI_DI_Uppgift_1_Salary_Program.Data.Data.Requests.Clear();
            CI_DI_Uppgift_1_Salary_Program.Data.Data.FillData();
            var admin = (CI_DI_Uppgift_1_Salary_Program.Models.Admin)CI_DI_Uppgift_1_Salary_Program.Functions.LoginLogout.Login("admin1", "admin1234");
            admin.GiveSalary();

            CI_DI_Uppgift_1_Salary_Program.Functions.LoginLogout.Login("teth", "334243");
            CI_DI_Uppgift_1_Salary_Program.Models.User user = (CI_DI_Uppgift_1_Salary_Program.Models.User)CI_DI_Uppgift_1_Salary_Program.Functions.LoginLogout.Login("Abbehh", "Abbehh1234");
            user.RequestChangeRole(CI_DI_Uppgift_1_Salary_Program.Models.Role.CEO);
            user.RequestSalaryChange(10000);
            user = (CI_DI_Uppgift_1_Salary_Program.Models.User)CI_DI_Uppgift_1_Salary_Program.Functions.LoginLogout.Login("ViktorPotter65", "TheChosenOne");
            user.RequestChangeRole(CI_DI_Uppgift_1_Salary_Program.Models.Role.Admin);
          
            //Abbehh CEO
            admin.AscceptRequest(CI_DI_Uppgift_1_Salary_Program.Data.Data.Requests[0]);
            //Viktor Admin
            admin.DenyRequest(CI_DI_Uppgift_1_Salary_Program.Data.Data.Requests[1]);
            //Abbehh 10000
            admin.AscceptRequest(CI_DI_Uppgift_1_Salary_Program.Data.Data.Requests[0]);
            admin.GiveSalary();
            CI_DI_Uppgift_1_Salary_Program.Functions.LoginLogout.DeleteAccountAdmin("ViktorPotter65", "TheChosenOne");
            admin.GiveSalary();

            var cheackuser = CI_DI_Uppgift_1_Salary_Program.Data.Data.Accounts.Find(x => x.Username == "Abbehh");
            Assert.AreEqual(20100, cheackuser.Saldo);
            Assert.AreEqual(10000, cheackuser.Salary);
            Assert.AreEqual(CI_DI_Uppgift_1_Salary_Program.Models.Role.CEO, cheackuser.Role);

            cheackuser = CI_DI_Uppgift_1_Salary_Program.Data.Data.Accounts.Find(x => x.Username == "Tehpson");
            Assert.AreEqual(300, cheackuser.Saldo);
            Assert.AreEqual(100, cheackuser.Salary);
            Assert.AreEqual(CI_DI_Uppgift_1_Salary_Program.Models.Role.CEO, cheackuser.Role);

            Assert.IsNull(CI_DI_Uppgift_1_Salary_Program.Functions.LoginLogout.Login("ViktorPotter65", "TheChosenOne"));
        }
    }
}
