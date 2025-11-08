using System.Linq;

namespace Week6
{
    public class Order : OrderBase
    {
        public Order(Customer customer, int orderid)
            :base(customer, orderid)
        { }

        public override string ToString()
        {
            var items = foodItems.Any()
                ? string.Join("\n", foodItems.Select(fi => fi.ToString()))
                : "(no items)";
            return $"Order #{OrderId} - Customer: {Customer.Name}\n----- Items ordered -----\n{items}\nTotal: {GetTotal()}$\nStatus: {Status}";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}
