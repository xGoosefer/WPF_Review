using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Review
{
    internal class Person
    {
       public List<Item> Inventory = new List<Item>();

        public Person() 
        {
            Inventory.Add(new Item());
        }


        public string GetInventoryItem()
        {
            string output = "Inventory\n";

            foreach (Item item in Inventory)
            {
                output += $"{item.ItemName} ({item.Description}) \n ";
            }

            return output;
        }
    }
}
