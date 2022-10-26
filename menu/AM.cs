using System;
using FDM.implementation;
using FDM.interfaces;

namespace FDM.menu
{
    public class AM
    {
        IAdminManager adminManager = new AdminManager();

        public void AdminMenu()
        {
            adminManager.ReadFromFile();
            bool isPrev = false;
            while (!isPrev)
            {
                Console.WriteLine("Enter 1 to register\nEnter 2 to login\nEnter 3 to view Admins\nEnter 0 for Main Menu");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    RegisterAdmin();
                }
                else if (choice == 2)
                {
                    Login();
                }
                else if (choice == 3)
                {
                    adminManager.GetAllAdmin();
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

        public void RegisterAdmin()
        {
            Console.Write("Enter your first name: ");
            string fName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lName = Console.ReadLine();
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());
            Console.Write("Enter your post: ");
            string post = Console.ReadLine();

            adminManager.CreateAdmin(fName, lName, email, pin, post);
            AdminMenu();
        }

        public void Login()
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());
            Admin ad = adminManager.Login(email, pin);
            if (ad != null)
            {
                Console.WriteLine("login successful");
                AdminSubMenu();
            }
            else
            {
                Console.WriteLine("wrong email or pin");
            }

        }

        public void AdminSubMenu()
        {
            bool isPrev = false;
            while(!isPrev)
            {
                Console.WriteLine("Enter 1 to Update admin\nEnter 2 to delete admin\nEnter 0 to go back ");
                int choice = int.Parse(Console.ReadLine());
                if(choice == 1)
                {
                    adminManager.UpdateAdmin();
                }
                else if(choice == 2)
                {
                    adminManager.DeleteAdmin();
                }
                else if(choice == 0)
                {
                    isPrev= true;
                }
                else{
                    Console.WriteLine("Invalid Option!");
                }
            }
        }
    }
}