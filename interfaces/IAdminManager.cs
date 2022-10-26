using FDM.models;
namespace FDM.interfaces
{
    public interface IAdminManager
    {
        public void CreateAdmin(string firstName, string lastName, string email, int pin, string post);
        public void UpdateAdmin();
        public void DeleteAdmin();
        public Admin GetAdmin(string email);
        public void GetAllAdmin();
        public Admin Login(string email, int pin);

        public void ReadFromFile();
        public void ReWriteFile();

    }
}