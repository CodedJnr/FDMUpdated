namespace FDM.interfaces
{
    public interface IDeliveryManManager
    {
         
        public bool CreateDeliveryMan(string email);
        public void UpdateDeliveryMan( string firstName, string lastName, string phoneNumber);
        public void DeleteDeliveryMan(string email);
        public void GetDeliveryMan(string email); 
        public  DeliveryMan Login(string email, int pin);

    }
}