using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaseysCards
{
    class Program
    {
        

        static void Main(string[] args)
        {
            User user = new User();
            user.displayWelcome();
            user.getFirstName();
            user.getLastName();
            user.getEmail();
            user.getExperienceLevel();
            user.setFirstName();
            user.setLastName();
            user.setEmail();
            user.setExperienceLevel();           
            user.makeChoice();
      
            Console.ReadLine();
            Catalogue catalogue = new Catalogue();
            
           
            Console.ReadLine();
            CardStock cardstock = new CardStock();
           
            user.buySupplies();
            Console.ReadLine();
            user.whatsNext();

            string choices;
            choices = Console.ReadLine();
            switch (choices.ToLower())
            {
                case "class":
                    catalogue.pickAClass();
                    break;
                case "tools":
                    cardstock.pickATool();
                    break;
                default:
                    user.makeChoice();
                    break;
            }


            
            
            

          


        }

        
    }
 }



