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
            List<string> emb = new List<string>();
            emb.Add("Rhinestones");
            emb.Add("Mini flowers");
            emb.Add("Ribbons");
            emb.Add("Labels");
            emb.Add("Glitter");
            emb.Add("Brads");
            emb.Add("Tags");
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
