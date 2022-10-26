using System;
using Cloned.menu;

namespace FDM.menu
{
    public class MM
    {
        public void MainMenu()
        {
            Console.WriteLine("Welcome To Wonder's Foods");
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("Enter 1 as Admin\nEnter 2 as Chef\nEnter 3 as Delivery\nEnter 4 as Customer\nEnter 0 to Exit Application");
                int opt = int.Parse(Console.ReadLine());
                if (opt == 1)
                {
                    AM am = new AM();
                    am.AdminMenu();
                }
                else if (opt == 2)
                {
                    CM cm = new CM();
                    cm.ChefMenu();
                }
                else if (opt == 0)
                {
                    Console.WriteLine("Shutting Down Application...");
                    isExit = true;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
        }

    }
}