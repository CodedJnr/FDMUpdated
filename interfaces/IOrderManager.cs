namespace FDM.interfaces
{
    public interface IOrderManager
    {
         public bool CreateOrder(string email);
         public void UpdateOrder( string firstName, string lastName, string phoneNumber);
         public void DeleteOrder();
         public void GetOrder(string email); 
    }
}