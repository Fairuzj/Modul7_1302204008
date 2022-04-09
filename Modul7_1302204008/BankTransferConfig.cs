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
            string jString = File.ReadAllText("C:/Users/User/source/repos/Modul7_1302204008/Modul7_1302204008/bank_transfer_config.json");
            dynamic data= JsonConvert.DeserializeObject(jString);
            return data;
        }
    }
}
