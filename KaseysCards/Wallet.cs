using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaseysCards
{
    class Wallet
    {
        double money;
      

        public Wallet()
        {
            money = 50;
        }
        
        public double balance(double amount)
        {
            return money;
        }
        public void spendMoney(double amount)
        {
            if (money - amount < 0)
            {
                Console.WriteLine("Please add money so you can buy you items.");
            }
            else
            {
                money -= amount;
            }
        
        }
        public void addMOney(double amount)
        {
            money += amount;
        }
        
       
    }

}

