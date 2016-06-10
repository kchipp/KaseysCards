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
            user.enterFirstName();
            user.enterLastName();
            user.enterEmail();
            user.enterExperienceLevel();
            user.makeChoice();
            
            Wallet wallet = new Wallet();
            wallet.getBalance();
            Console.ReadLine();
            Catalogue catalogue = new Catalogue();
            catalogue.pickAClass();
            Console.WriteLine("Please enter the number of the class you wish to enroll in.");
            Console.ReadLine();
            catalogue.enrollCB();
            //wallet.addMoney();


            Inventory inventory = new Inventory();
            CardStock cardstock = new CardStock();
            ////cardstock.cardstockAvailable();
            //cardstock.restockCS();

            //Shop shop = new Shop();
            //shop.buyCS(wallet);
            //double purchase = shop.buyCS(user.wallet);
            //Console.WriteLine(purchase);
            //Console.WriteLine(user.wallet.getBalance());
           
            
        }

        
    }
 }



