namespace Week6
{
    public abstract class OrderBase
    {
        protected int OrderId;
        protected List<FoodItem> foodItems;
        public Customer Customer;
        public OrderStatus Status;

        protected OrderBase(Customer customer, int orderid)
        {
            Customer = customer;
            OrderId = orderid;
            foodItems = new List<FoodItem>();
        }
        public void AddItem(FoodItem item)
        {
            foodItems.Add(item);
        }
        public decimal GetTotal()
        {
            decimal total = 0;
            foreach(var item in foodItems)
                total += item.Price;
            return total;
        }
        public abstract void DisplayInfo();
    }

    public enum  OrderStatus
    {
        Pending,
        Preparing,
        Delivering,
        Completed
    }
}
