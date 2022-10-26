
namespace FDM
{
    public class Order
    {
        public string CustomerName { get; set; }
        public string DeliveryAddress { get; set; }
        public string OrderStatus { get; set; }
        public double TotalPaid { get; set; }
        public Order(string customerName, string deliveryAddress, string orderStatus, double totalPaid)
        {
            CustomerName = customerName;
            DeliveryAddress = deliveryAddress;
            OrderStatus = orderStatus;
            TotalPaid = totalPaid;


        }
    }
}