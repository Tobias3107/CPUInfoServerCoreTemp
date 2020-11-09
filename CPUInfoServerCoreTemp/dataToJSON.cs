using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CoreTemp.Plugin;
using Newtonsoft.Json;

namespace CPUInfoServerCoreTemp
{
    class dataToJSON
    {
        public static void transferToJSON(CoreTempSharedData Data, String filePath)
        {
            if(!File.Exists(filePath))
            {
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.WriteLine(JsonConvert.SerializeObject(Data));
                }        
            }else
            {
                File.WriteAllText(filePath, JsonConvert.SerializeObject(Data));
            }    
        }
    }
}
