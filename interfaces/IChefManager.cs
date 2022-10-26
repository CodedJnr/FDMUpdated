using FDM.models;
namespace FDM.interfaces
{
    public interface IChefManager
    {

        public void CreateChef(string firstName, string lastName, int pin, string email);
        public void UpdateChef(string firstName, string lastName, int pin, string email);
        public void DeleteChef(string email);
        public Chef GetChef(string email);
        public Chef Login(string email, int pin);


    }
}