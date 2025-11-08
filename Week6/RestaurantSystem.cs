namespace Week6
{
    public class RestaurantSystem
    {
        private List<Customer> _customers;
        private List<DeliveryDriver> _drivers;
        private List<FoodItem> _menu;
        private List<Order> _orders;
        public RestaurantSystem()
        {
            _customers = new List<Customer>();
            _drivers = new List<DeliveryDriver>();
            _menu = new List<FoodItem>();
            _orders = new List<Order>();
        }
        public void RegisterCustomer(string name, string email)
        {
            _customers.Add(new Customer(_customers.Count + 1, name, email));
        }
        public void AddDriver(string name)
        {
            _drivers.Add(new DeliveryDriver(_drivers.Count + 1, name));
        }
        public void AddMenuItem(FoodItem item)
        { 
            _menu.Add(item);
        }
        public void ShowMenu()
        {
            Console.WriteLine("----- Menu -----");
            _menu.ForEach(menuItem => menuItem.DisplayInfo());

        }
        public Order CreateOrder(Customer customer, List<int> menuIndexes)
        {
            var order = new Order(customer, customer.Id);
            foreach (var menuIndex in menuIndexes)
                order.AddItem(_menu[menuIndex]);
            _orders.Add(order);
            return order;

        }
        public DeliveryDriver AssignDriver()
        {
            _drivers.Sort();
            var driver = _drivers.First();
            driver.AssignDelivery();
            return driver;
        }
        public void ShowOrders()
        {
            Console.WriteLine("Available orders: ");
            _orders.ForEach(orderItem => orderItem.DisplayInfo());

        }
        public Customer GetCustomer(int index)
        {         
            foreach (Customer customer in _customers)
            {
                if (customer.Id == index)
                    return customer;
            }

            throw new Exception("Customer not found");
        }
    }
}
