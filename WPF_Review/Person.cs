using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Review
{
    public class Person
    {
       public List<Item> Inventory = new List<Item>();
        public string PersonName = "Anon";
        public int CurrentLocation = 0;

        public Person() 
        {
            Inventory.Add(new Item() { ItemName = "Map", Description = "Old map"});
            Inventory.Add(new Item() { ItemName = "Pin", Description = "Has some street rats on it" });
            Inventory.Add(new Item() { ItemName = "Photo", Description = "A dog with golden fur posed for this." });
        }


        public string GetInventoryItem()
        {
            string output = "\n Your Inventory\n";

            foreach (Item item in Inventory)
            {
                output += $"{item.ItemName} ({item.Description}) \n ";
            }

            return output;
        }
    }
}
