using System;
using System.Collections.Generic;
using System.IO;
using FDM.interfaces;

namespace FDM.implementation
{
    public class AdminManager : IAdminManager
    {
        public static List<Admin> Admins = new List<Admin>();
        public string FilePath = "./Files/admin.txt";

        public void CreateAdmin(string firstName, string lastName, string email, int pin, string post)
        {
            Random rand = new Random();
            int adminID = rand.Next(10, 99);
            Admin admin = new Admin(firstName, lastName, email, pin, adminID, post);
            Admins.Add(admin);
            using (StreamWriter writer = new StreamWriter(FilePath, append: true))
            {
                writer.WriteLine(admin.ConvertToFileFormat());
            }


            Console.WriteLine("created succesfully");
        }

        public void DeleteAdmin()
        {
            Console.WriteLine("Enter email of Admin to delete: ");
            string email = Console.ReadLine().Trim();
            foreach (var item in Admins)
            {
                if (item.Email == email)
                {
                    Admins.Remove(item);
                    ReWriteFile();
                    break;
                }
            }
            Console.WriteLine("deleted succesfully");
        }

        public Admin GetAdmin(string email)
        {
            foreach (var item in Admins)
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        public void GetAllAdmin()
        {
            foreach (var item in Admins)
            {
                Console.WriteLine(item);
            }
        }

        public Admin Login(string email, int pin)
        {
            foreach (var item in Admins)
            {
                if (item.Email == email && item.Pin == pin)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateAdmin()
        {
            Console.WriteLine("Enter email of Admin to Update: ");
            string email = Console.ReadLine().Trim();
            Admin adminToUpdate = GetAdmin(email);
            if (adminToUpdate != null)
            {
                Console.WriteLine("Update First Name: ");
                string firstName = Console.ReadLine().Trim();
                adminToUpdate.FirstName = firstName;

                Console.WriteLine("Update Last Name: ");
                string lastName = Console.ReadLine().Trim();
                adminToUpdate.LastName = lastName;

                Console.WriteLine("Update Post: ");
                string post = Console.ReadLine().Trim();
                adminToUpdate.Post = post;
                ReWriteFile();
                Console.WriteLine("admin updated successfully");
            }
            else
            {
                Console.WriteLine("admin not found");
            }
        }

        public void ReadFromFile()
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                while (reader.Peek() > -1)
                {
                    string adminInfo = reader.ReadLine();
                    Admins.Add(Admin.ConvertToAdmin(adminInfo));
                }
            }
        }

        public void ReWriteFile()
        {
            File.WriteAllText(FilePath, string.Empty);
            using (StreamWriter writer = new StreamWriter(FilePath, append: true))
            {
                foreach (var admin in Admins)
                {
                    writer.WriteLine(admin.ConvertToFileFormat());
                }
            }
        }
    }

}