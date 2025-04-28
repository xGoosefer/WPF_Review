using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPF_Review
{
    public class Person
    {
       public List<Item> Inventory = new List<Item>();
        public string PersonName = "Anon";
        public int CurrentLocation = 0;
        // Img local?
      //  public string AvatarIconLocal = "Avatar.bmp";
        public BitmapImage AvatarIcon = new BitmapImage(new Uri("Avatar.bmp", UriKind.Relative));

        public Person() 
        {
            Inventory.Add(new Item() { ItemName = "Minor Gear Part", Description = "Worth $5"});
            Inventory.Add(new Item() { ItemName = "Small Ba", Description = "Has some street rats on it" });
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
