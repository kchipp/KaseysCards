﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaseysCards
{
    class CardStock : Inventory
    {
        public CardStock()
        {
            quantity = 50;
            List<string> papers = new List<string>();
            papers.Add("1-Matte");
            papers.Add("2-Pearl");
            papers.Add("3-Watercolour");
            papers.Add("4-Filigree");
            papers.Add("5-Damask");
            papers.Add("6-Metallic");
            papers.Add("7-Linen");
            foreach (string paper in papers) 
            {
                Console.WriteLine(paper);
                
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
                    Console.WriteLine("Matte-press enter to continue");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Pearl-press enter to continue");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Watercolour-press enter to continue");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Matte-press enter to continue");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Matte-press enter to continue");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Matte-press enter to continue");
                    Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("Matte-press enter to continue");
                    Console.ReadLine();
                    break;
                default:
                    pickATool();
                    break;

            }
        }
        public void restockCS()
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
