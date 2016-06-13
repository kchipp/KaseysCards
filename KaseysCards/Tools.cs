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
            tools.Add("Glue");
            tools.Add("Glue Dots");
            tools.Add("Scissors");
            tools.Add("Score & Fold");
            tools.Add("Cuting Mat");
            tools.Add("Paper trimmer");
            tools.Add("Craft Punches");
            tools.Add("X-Acto Knife");
            tools.Add("Mod Podge");
            tools.Add("Glue Gun");
            foreach (string tool in tools)
            {
                Console.WriteLine(tool);
                Console.ReadLine();
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
    


    