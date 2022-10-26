using System;
using FDM;
using FDM.implementation;
using FDM.interfaces;

namespace Cloned.menu
{
    public class CM
    {
        IChefManager chefManager = new ChefManager();

        public void ChefMenu()
        {
            bool isPrev = false;
            while (!isPrev)
            {
                Console.WriteLine("Enter 1 to register\nEnter 2 to login\nEnter 0 for Main Menu");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    RegisterChefMenu();
                }
                else if (choice == 2)
                {
                    LoginMenu();
                }
                else if(choice == 0)
                {
                    isPrev = true;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
        }

        public void RegisterChefMenu()
        {
            Console.Write("Enter your first name: ");
            string fName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lName = Console.ReadLine();
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());

            chefManager.CreateChef(fName, lName, pin, email);
            ChefMenu();
        }

        public void LoginMenu()
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());
            Chef ad = chefManager.Login(email, pin);
            if (ad != null)
            {
                Console.WriteLine("login successful");
                ChefSubMenu();
            }
            else
            {
                Console.WriteLine("wrong email or pin");
            }
        }

        public void ChefSubMenu()
        {
            Console.WriteLine("Enter 1 to register food\nEnter 2 to update food");
        }



    }
}