using System;
using System.Collections.Generic;
using System.Text;

namespace CI_DI_Uppgift_1_Salary_Program.Functions
{
    class LoginLogout
    {
        public static Models.Account Login(string username, string password) => Data.Data.Accounts.Find(x => x.Username == username && x.Password == password);
    }
}
