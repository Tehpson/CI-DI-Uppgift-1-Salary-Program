using System;
using System.Collections.Generic;
using System.Text;

namespace CI_DI_Uppgift_1_Salary_Program.Data
{
    static class Data
    {
        static public List<Models.Account> Accounts { get; set; } = new List<Models.Account>();
        static public List<Models.Request> Requests { get; set; } = new List<Models.Request>();

        static public void FillData()
        {
            var accounts = Functions.DataHandler.GetSettings();
            if(accounts == null)
            {
                accounts = new List<Models.Account>();
                accounts.Add(new Models.Admin { Username = "admin1", Password = "admin1234", Role = Models.Role.Admin });
                accounts.Add(new Models.User { Username = "Abbehh", Password = "Abbehh1234", Role = Models.Role.Janitor });
                accounts.Add(new Models.User { Username = "Tehpson", Password = "SyperSecurePasswrod!123", Role = Models.Role.CEO });
                accounts.Add(new Models.User { Username = "ViktorPotter65", Password = "TheChosenOne", Role = Models.Role.yeeter });
                Functions.DataHandler.SaveData(accounts);
            }
            Accounts.AddRange(accounts);
        }
    }
}
