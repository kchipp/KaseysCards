using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaseysCards
{
    class Embellishments : Inventory
    {
    public Embellishments()
        {
            quantity = 50;
            List<string> embs = new List<string>();
            embs.Add("1-Rhinestones");
            embs.Add("2-Mini Flowers");
            embs.Add("3-Ribbons");
            embs.Add("4-Labels");
            embs.Add("5-Glitter");
            embs.Add("6-Brads");
            embs.Add("7-Tags");
            foreach (string emb in embs)
            {
                Console.WriteLine(emb);

            }

        }
        public void pickAnEmbellishment()
        {
            Console.WriteLine("Please enter the number of the embellishment you wish to buy.");
            int pickE;


            pickE = int.Parse(Console.ReadLine());
            switch (pickE)
            {
                case 1:
                    Console.WriteLine("Rhinestones-press enter to continue");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Mini Flowers-press enter to continue");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Ribbons-press enter to continue");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Lables-press enter to continue");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Glitter-press enter to continue");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Brads-press enter to continue");
                    Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("Tags-press enter to continue");
                    Console.ReadLine();
                    break;
                
                default:
                    pickAnEmbellishment();
                    break;

            }
        }
        public void restockEmbells()
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
