﻿using CI_DI_Uppgift_1_Salary_Program.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CI_DI_Uppgift_1_Salary_Program.Functions
{
    static class LoginLogout
    {
        public static Models.Account Login(string username, string password) => Data.Data.Accounts.Find(x => x.Username == username && x.Password == password);

        internal static void DeleteAccountAdmin(string username, string password) => Data.Data.Accounts.Remove(Data.Data.Accounts.Find(x => x.Username == username && x.Password == password));

        internal static void DeleteAccountUser(User user, string password) => Data.Data.Accounts.Remove(Data.Data.Accounts.Find(x => x == user && x.Password == password));
    }
}
