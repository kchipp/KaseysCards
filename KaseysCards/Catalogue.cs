using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaseysCards
{
    class Catalogue
    {
        public string trainings;
        public string enroll;
        public double cost;

        public Catalogue()
        {
            List<string> trainings = new List<string>();
            trainings.Add("1 - Card Basics");
            trainings.Add("2 - Paper Making");
            trainings.Add("3 - Advanced Card Making");
            foreach (string training in trainings)
            {
                Console.WriteLine(training);
                
                Console.ReadLine();
                
            }

        }
        public void pickAClass()
        {
            Console.WriteLine("Please enter the number of the class you wish to enroll in.");
            int pick;
            pick = int.Parse(Console.ReadLine());
            switch (pick)
            {
                case 1:
                    Console.WriteLine("Card Basics");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Paper Making");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Advanced Card Design");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number. Try again.");
                    pickAClass();
                    break;


            }
        }
        public string enrollCB()
        {
            string cb = enrolled;
            enrolled

        }































    }
}
