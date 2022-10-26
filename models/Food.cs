namespace FDM.models
{
    public class Food
    {
        public int RefNumber { get; set; }
        public string FoodName { get; set; }
        public double Price { get; set; }
        
        public Food(int refNumber,string foodName, double price)
        {
            RefNumber = refNumber;
            FoodName = foodName;
            Price = price;
        }
        
    }
}