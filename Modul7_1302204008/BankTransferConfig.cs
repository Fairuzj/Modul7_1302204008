using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7_1302204008
{
    internal class BankTransferConfig
    {
        public dynamic ReadJson()
        {
            string direct = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string jString = File.ReadAllText(direct+"/bank_transfer_config.json");
            dynamic data= JsonConvert.DeserializeObject(jString);
            return data;
        }
    }
}
