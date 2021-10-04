using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CI_DI_Uppgift_1_Salary_Program.Functions
{
    static class DataHandler
    {
        public static string Path { get;} = Environment.CurrentDirectory;
        public static Models.AccountRoot GetSettings() => JsonConvert.DeserializeObject<Models.AccountRoot>(File.ReadAllText(Path));
        public static void SaveData(Models.AccountRoot data) => File.WriteAllText(Path, JsonConvert.SerializeObject(data));
    }
}
