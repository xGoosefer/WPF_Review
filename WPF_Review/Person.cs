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
            Inventory.Add(new Item() { ItemName = "Minor Gear Part", Description = "A vauluable item."});
           
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
