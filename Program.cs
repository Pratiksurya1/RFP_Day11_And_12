using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Program
    {
        public static void Main(String[] args)
        {
            FetchJSonDate fetchJSonData = new FetchJSonDate();
            Inventory riceData = fetchJSonData.ReadTheJSonFile("D:/.Net/C#/InventoryManagement/JsFile.json");

            Console.WriteLine("=========== Rice ============");
            for (int i = 0; i<riceData.typesofRice.Count;i++)
            {
                Console.WriteLine(riceData.typesofRice[i].name);
                Console.WriteLine(riceData.typesofRice[i].weight);
                Console.WriteLine(riceData.typesofRice[i].price);
                Console.WriteLine("Total price of : "+riceData.typesofRice[i].getTotalValue());
            }
            //object obj = new TypesOfRice();
            //var json = JsonSerializer.Serialize(obj);
            //Console.WriteLine(json);

            Console.WriteLine("============= Pulses ===============");
            for (int j = 0; j < riceData.typesOfPulses.Count; j++)
            {
                Console.WriteLine(riceData.typesOfPulses[j].name);
                Console.WriteLine(riceData.typesOfPulses[j].weight);
                Console.WriteLine(riceData.typesOfPulses[j].price);
                Console.WriteLine("Total price of : " + riceData.typesofRice[j].getTotalValue());
            }

            Console.WriteLine("============= Wheats ===============");
            for (int j = 0; j < riceData.typesOfWheats.Count; j++)
            {
                Console.WriteLine(riceData.typesOfWheats[j].name);
                Console.WriteLine(riceData.typesOfWheats[j].weight);
                Console.WriteLine(riceData.typesOfWheats[j].price);
                Console.WriteLine("Total price of : " + riceData.typesofRice[j].getTotalValue());
            }
        }
    }
}
