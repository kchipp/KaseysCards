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
                    Console.WriteLine("You have been enrolled in Card Basics.  We'll see you there.");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Paper Making");
                    Console.WriteLine("You have been enrolled in Paper Making  We'll see you there.");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Advanced Card Design");
                    Console.WriteLine("You have been enrolled in Advanced Card Design.  We'll see you there.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number. Try again.");
                    pickAClass();
                    break;


            }
        }
        
          

}































    }
//}
