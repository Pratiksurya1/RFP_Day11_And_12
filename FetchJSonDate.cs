using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventoryManagement
{
    public class FetchJSonDate
    {
        public Inventory ReadTheJSonFile(String path)
        {
            using (StreamReader file=new StreamReader(path))
            {
                try
                {
                    String json = file.ReadToEnd();  
                    return JsonConvert.DeserializeObject<Inventory>(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        //public void WriteData()
        //{
        //    String StrResultJson = JsonConvert.SerializeObject(Inventory);
        //}




        //public Inventory WriteTheJSonFile(String path)
        //{
        //    using(StreamWriter file=new StreamWriter(path))
        //    {
        //        try
        //        {
        //            var Inventory=
        //        }
        //    }
        //}
    }
}
