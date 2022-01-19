using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Inventory
    {
        public List<TypesOfRice>typesofRice;
        public List<TypesOfPulses>typesOfPulses;
        public List<TypesOfWheats> typesOfWheats;
    }
    public class TypesOfRice
    {
        public String name;
        public int weight;
        public int price;
        public int getTotalValue()
        {
            return weight* price; 
        }
    }
    public class TypesOfPulses
    {
        public String name;
        public int weight;
        public int price;
        public int getTotalValue()
        {
            return weight * price;
        }
    }
    public class TypesOfWheats
    {
        public String name;
        public int weight;
        public int price;
        public int getTotalValue()
        {
            return weight * price;
        }
    }
}
