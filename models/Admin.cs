namespace FDM
{
    public class Admin : User
    {
        public int AdminID { get; set; }
        public string Post { get; set; }
        public Admin (string firstName, string lastName, string email, int pin, int adminID, string post) : base(firstName, lastName, email, pin)
        {
            AdminID = adminID;
            Post = post;
        }

        public override string ToString()
        {
            return $"Admin {LastName} {FirstName} \t Post: {Post}";
        }
        public string Test(string name, int age)
        {
            return name;
        }
        public string ConvertToFileFormat()
        {
            return $"{AdminID}***{FirstName}***{LastName}***{Email}***{Pin}***{Post}";
        }

        public static Admin ConvertToAdmin(string adminInfo)
        {
            string[] info = adminInfo.Split("***");
            return new Admin(info[1],info[2],info[3], int.Parse(info[4]), int.Parse(info[0]), info[5]);
        }

    }
}
