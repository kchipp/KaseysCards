using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaseysCards
{
    class StampsAndStickers : Inventory
    {
    public StampsAndStickers()
        {
            quantity = 50;
            List<string> sas = new List<string>();
            sas.Add("Hearts Stamp Collection");
            sas.Add("Cute Bugs Stamp Collection");
            sas.Add("Flowers Stamp Collection");
            sas.Add("'Handcrafted' Stamp Collection");
            sas.Add("Travel Stamp Collection");
            sas.Add("Curly Alphabet Stickers");
            sas.Add("Block Alphabet Stickers");
            sas.Add("Christmas Stickers");
            sas.Add("Graduation Stickers");
            sas.Add("Thank you Stickers");
            sas.Add("'Over the Hill' Stickers");

        }
        public void restockSAS()
        {
            if (quantity <= 50)
            {
                while (quantity < 20)
                {
                    Console.WriteLine("Inventory Low.  Please check back soon.");
                    quantity += 10;
                }

            }
            else
            {
                Console.WriteLine("Product Available");
            }
        }




       
    }
}
