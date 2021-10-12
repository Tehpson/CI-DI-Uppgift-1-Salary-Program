using System;
using System.Collections.Generic;
using System.Text;

namespace CI_DI_Uppgift_1_Salary_Program.Data
{
    public static class Data
    {
        static public List<Models.Account> Accounts { get; set; } = new List<Models.Account>();
        static public List<Models.Request> Requests { get; set; } = new List<Models.Request>();

        static public void FillData()
        {

            Accounts.Add(new Models.Admin { Username="admin1", Password = "admin1234", Role = Models.Role.Admin });
            Accounts.Add(new Models.User { Username="Abbehh", Password = "Abbehh1234", Role = Models.Role.Janitor });
            Accounts.Add(new Models.User { Username="Tehpson", Password = "SyperSecurePasswrod!123", Role = Models.Role.CEO });
            Accounts.Add(new Models.User { Username="ViktorPotter65", Password = "TheChosenOne", Role = Models.Role.yeeter });
        }
    }
}
