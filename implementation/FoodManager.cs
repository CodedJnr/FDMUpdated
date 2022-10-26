using System;
using System.Collections.Generic;
using FDM.interfaces;
using FDM.models;

namespace FDM.implementation
{
    public class FoodManager : IFoodManager
    {
        public static List<Food> listOfFoods = new List<Food>();

        public void CreateFood(string foodName, double price)
        {
            Random rand = new Random();
            int refNumber = rand.Next(100, 999);
            Food food = new Food(refNumber,foodName, price);
            listOfFoods.Add(food);
            Console.WriteLine($"{foodName} created successfully");
        }
        public void UpdateFood(string foodName, string newFoodName, double newPrice)
        {
            Food foodToUpdate = GetFood(foodName);
            if(foodToUpdate != null)
            {
                foodToUpdate.FoodName = newFoodName;
                foodToUpdate.Price = newPrice;
                Console.WriteLine("food update successful");
            }
            else
            {
                Console.WriteLine("food not found");
            }
            
        }
        public void DeleteFood(int refNumber)
        {
            foreach (var item in listOfFoods)
            {
                if(item.RefNumber == refNumber)
                {
                    listOfFoods.Remove(item);
                    break;
                }
            }
            Console.WriteLine("removed successfully");
        }
        public Food GetFood(string foodName)
        {
            foreach (var item in listOfFoods)
            {
                if(item.FoodName == foodName)
                {
                    return item;
                }   
            }
            return null;

        }
        public Food GetFood(int refNumber)
        {
            foreach (var item in listOfFoods)
            {
                if(item.RefNumber == refNumber)
                {
                    return item;
                }
            }
            return null;
        }
    }
}