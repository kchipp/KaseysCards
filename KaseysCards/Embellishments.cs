﻿using System;
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