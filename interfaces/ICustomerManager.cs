namespace FDM.interfaces
{
    public interface ICustomerManager
    {
        public  void CreateCustomer(string firstName, string lastName, string email, int pin, string address, string phoneNumber);
        public void UpdateCustomer( string firstName, string lastName, int pin);
        public void DeleteCustomer(Customer customer);
        public Customer GetCustomer(string customerEmail);
        public Customer LoginCustomer(string email, int pin);
        public void AddMoneyToWallet(string email, double amont);
    }
}