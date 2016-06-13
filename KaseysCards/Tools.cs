using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaseysCards
{
    class Tools : Inventory
    {
        public string tools;

        public Tools()
        
        {
            quantity = 50;
            List<string> tools = new List<string>();
            tools.Add("1-Glue");
            tools.Add("2-Glue Dots");
            tools.Add("3-Scissors");
            tools.Add("4-Score & Fold");
            tools.Add("5-Cuting Mat");
            tools.Add("6-Paper trimmer");
            tools.Add("7-Craft Punches");
            tools.Add("8-X-Acto Knife");
            tools.Add("9-Mod Podge");
            tools.Add("10-Glue Gun");
            foreach (string tool in tools)
            {
                Console.WriteLine(tool);
                
            }
        }
        public void pickATool()
        {
            Console.WriteLine("Please enter the number of the tool you wish to buy.");
            int pickT;


            pickT = int.Parse(Console.ReadLine());
            switch (pickT)
            {
                case 1:
                    Console.WriteLine("Glue-press enter to continue");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Glue Dots-press enter to continue");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Scisors-press enter to continue");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Score and Fold-press enter to continue");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Cutting Mat-press enter to continue");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Paper Trimmer-press enter to continue");
                    Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("Craft Punches-press enter to continue");
                    Console.ReadLine();
                    break;
                case 8:
                    Console.WriteLine("X-Acto-press enter to continue");
                    Console.ReadLine();
                    break;
                case 9:
                    Console.WriteLine("Mod Podge-press enter to continue");
                    Console.ReadLine();
                    break;
                case 10:
                    Console.WriteLine("Glue gun-press enter to continue");
                    Console.ReadLine();
                    break;
                default:
                    pickATool();
                    break;

            }
        }
        public void restockTools()
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
    


    