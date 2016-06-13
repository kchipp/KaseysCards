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
            user.displaySupplyMenu();

            Console.ReadLine();
            Catalogue catalogue = new Catalogue();
            catalogue.pickAClass();
            user.whatsNext();

            Console.ReadLine();
            user.buySupplies();
            CardStock cardstock = new CardStock();
            cardstock.pickAPaper();
            Tools tools = new Tools();
            tools.pickATool();
            Embellishments embellishments = new Embellishments();
            embellishments.pickAnEmbellishment();
            StampsAndStickers stamps = new StampsAndStickers();
            stamps.pickAStamp();
            
            Console.ReadLine();




            user.whatsNext();

            
            
            

          


        }

        
    }
 }



