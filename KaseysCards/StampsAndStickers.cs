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
            List<string> sass = new List<string>();
            sass.Add("1-Hearts Stamp Collection");
            sass.Add("2-Cute Bugs Stamp Collection");
            sass.Add("3-Flowers Stamp Collection");
            sass.Add("4-'Handcrafted' Stamp Collection");
            sass.Add("5-Travel Stamp Collection");
            sass.Add("6-Curly Alphabet Stickers");
            sass.Add("7-Block Alphabet Stickers");
            sass.Add("8-Christmas Stickers");
            sass.Add("9-Graduation Stickers");
            sass.Add("10Thank you Stickers");
            foreach (string sas in sass)
            {
                Console.WriteLine(sas);

            }

        }
        public void pickAStamp()
        {
            Console.WriteLine("Please enter the number of the stamp or sticker you wish to buy.");
            int pickS;


            pickS = int.Parse(Console.ReadLine());
            switch (pickS)
            {
                case 1:
                    Console.WriteLine("Hearts Collection-press enter to continue");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Cute Bugs Collection-press enter to continue");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Flowers Collection-press enter to continue");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("'Handcraftred' Collection-press enter to continue");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Travel Collection-press enter to continue");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Curly Collection-press enter to continue");
                    Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("Block Collection-press enter to continue");
                    Console.ReadLine();
                    break;
                case 8:
                    Console.WriteLine("Christmas Collection-press enter to continue");
                    Console.ReadLine();
                    break;
                case 9:
                    Console.WriteLine("Graduation Collection-press enter to continue");
                    Console.ReadLine();
                    break;
                case 10:
                    Console.WriteLine("Thank you Collections-press enter to continue");
                    Console.ReadLine();
                    break;
                default:
                    pickAStamp();
                    break;

            }
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
