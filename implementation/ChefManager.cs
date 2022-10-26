using System;
using System.Collections.Generic;
using FDM.interfaces;
namespace FDM.implementation
{
    public class ChefManager : IChefManager
    {
        public static List<Chef> listOfChefs = new List<Chef>();

        public void CreateChef(string firstName, string lastName, int pin, string email)
        {
            Random rand = new Random();
            int chefID = rand.Next(10, 99);
            Chef chef = new Chef(firstName, lastName, email, pin, chefID);
            listOfChefs.Add(chef);
            Console.WriteLine("created succesfully");
        }

        public void DeleteChef(string email)
        {
            foreach (var item in listOfChefs)
            {
                if (item.Email == email)
                {
                    listOfChefs.Remove(item);
                    break;
                }
            }
            Console.WriteLine("deleted succesfully");
        }

        public Chef GetChef(string email)
        {
            foreach (var item in listOfChefs)
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        public Chef Login(string email, int pin)
        {
            foreach (var item in listOfChefs)
            {
                if (item.Email == email && item.Pin == pin)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateChef(string firstName, string lastName, int pin, string email)
        {
            Chef chefToUpdate = GetChef(email);
            if (chefToUpdate != null)
            {
                chefToUpdate.FirstName = firstName;
                chefToUpdate.LastName = lastName;
                chefToUpdate.Pin = pin;
                Console.WriteLine("Chef updated successfully");
            }
            else
            {
                Console.WriteLine("Chef not found");
            }
        }

        private Chef GetChef(object email)
        {
            foreach (var item in listOfChefs)
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;;
        }
    }

}