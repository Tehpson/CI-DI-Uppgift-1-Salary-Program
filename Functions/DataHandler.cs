using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CI_DI_Uppgift_1_Salary_Program.Functions
{
    public static class DataHandler
    {
        public static string DataPath { get;} = Path.Combine(Environment.CurrentDirectory,"Accounts.json");
        public static List<Models.Account> GetSettings()
        {
            if (File.Exists(DataPath)){
                return JsonConvert.DeserializeObject<List<Models.Account>>(File.ReadAllText(DataPath));
            }
            else return null;
            
        }

        public static void SaveData(List<Models.Account> data) => File.WriteAllText(DataPath, JsonConvert.SerializeObject(data));
    }
}
