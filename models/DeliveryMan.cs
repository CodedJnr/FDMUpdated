namespace FDM
{
    public class DeliveryMan : User
    {
        public string BikePlateNumber { get; set; }
        public string DeliveryManPhoneNumber { get; set; }
        public DeliveryMan (string firstName, string lastName, string email, int pin, string bikePlateNumber, string deliveryManPhoneNumber) : base(firstName, lastName, email, pin)
        {
            BikePlateNumber = bikePlateNumber;
            DeliveryManPhoneNumber = deliveryManPhoneNumber;

        }
    }
}