using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaseysCards
{
    class User
    {
        string name;
        string age;
        string emailAddress;
        int experienceLevel;
        public Wallet wallet;
        public Inventory inventory;
        public User()
        {
            name = name;
            age = age;
            emailAddress = emailAddress;
            experienceLevel = experienceLevel;
            wallet = new Wallet();

        }

        public void displayWelcome()
        {
            Console.WriteLine("Welcome to Kasey's Cards!\n  \nWe're here to help you start learning how to make cards, \nfind classes to improve your skills, \nand buy supplies to make all the cards you want.  \n\nLet's get started...\nPress enter to continue.");
            Console.ReadLine();
        }
        public void enterFirstName()
        {
            Console.WriteLine("Please enter your first name: ");
            Console.ReadLine();
        }
        public void enterLastName()
        {
            Console.WriteLine("Please enter your last name: ");
            Console.ReadLine();
        }
        public void enterEmail()
        {
            Console.WriteLine("Please enter your eMail address: ");
            Console.ReadLine();
        }
        public void enterExperienceLevel()
        {
            
            Console.WriteLine("Please enter your level of experience. \n" +
                "Type: \nB for Beginner \nM for Moderate \nA for Advanced");
            string experience;
            experience = Console.ReadLine();
            switch (experience.ToLower())
            {
                case "b":
                    Console.WriteLine("YAY! Welcome! Press enter to continue:");
                    Console.ReadLine();
                    break;
                case "m":
                    Console.WriteLine("We're happy to have you here.  Press enter to continue:");
                    Console.ReadLine();
                    break;
                case "a":
                    Console.WriteLine("Master. How may we help you? Press enter to continue:");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please enter B, M, or A");
                    enterExperienceLevel();
                    break;                   

            }
            
        }
       
        public void makeChoice()
        {

            Console.Clear();
            Console.WriteLine("Kasey's Cards\n\n");
            Console.WriteLine("What would you like to do today? \n \nPress B for Buy Supplies. \nPress E for Enroll in a Class. \nPress R for Return to Welcome Screen");

            Console.WriteLine("Enter your choice now: ");
            string choice;
            choice = Console.ReadLine();
            switch (choice.ToLower())
            {
                case "b":
                    Console.WriteLine("You chose Buy Supplies. Press Enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    buySupplies();
                    break;
                case "e":
                    Console.WriteLine("You chose Enroll in a Class. Press Enter to continue.");
                    Console.ReadLine();
                    enrollInClass();
                    break;
                case "r":
                    Console.Clear();
                    displayWelcome();
                    makeChoice();
                    break;
                default:
                    Console.WriteLine("Please enter B, E, or R");                    
                    makeChoice();
                    break;
            }


        }

        public void buySupplies()
        {
            Console.WriteLine("Kasey's Cards\n\n");
            Console.WriteLine("What would you like to buy today?");
        }
        public void enrollInClass()
        {
            displayEnrollmentMenu();
            string enrollOptions = getUserEnrollmentMenuChoice();
            switch (enrollOptions.ToLower())
            {
                case "l":
                    Training t = new Training();
                    t.viewTrainings();
                    Console.Clear();
                    enrollInClass();
                    break;
                case "e":
                    Console.WriteLine("Which class would you like to enroll in?");
                    break;
                default:
                    makeChoice();
                    break;

            }
            
        }
        private void displayEnrollmentMenu()
        {
            Console.Clear();
            Console.WriteLine("Kasey's Cards\n\n");
            Console.WriteLine("You chose Enroll in a Class" +
                "\nPress L to see the List of current classes" +
                "\nPress E to proceed to Enrolling");

        }
        private string getUserEnrollmentMenuChoice()
        {
            string enrollOptions;
            enrollOptions = Console.ReadLine();
            return enrollOptions;
        }
        

    }

} 

