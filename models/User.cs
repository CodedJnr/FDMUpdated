
namespace FDM
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Pin { get; set; }


        public User(string firstName, string lastName, string email, int pin)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Pin = pin;

        }




    }
}