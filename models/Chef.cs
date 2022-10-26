namespace FDM
{
    // the solid principle******    

    public class Chef : User
    {
        public int ChefID { get; set; }
        public Chef(string firstName, string lastName, string email, int pin, int chefID) : base(firstName, lastName, email, pin)
        {
            ChefID = chefID;
            

        }
    }
}