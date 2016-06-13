using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaseysCards
{
    class Training
    {
        int basicPrice = 25;
        int paperPrice = 20;
        int advancedPrice = 45;

        public Training()
        {

        }
        public void viewTrainings()
        {
            StreamReader myReader = new StreamReader("Trainings.txt");
            string line = "";

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }
            myReader.Close();
            Console.ReadLine();


        }

    }   
     
}
