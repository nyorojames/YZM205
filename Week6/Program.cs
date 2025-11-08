namespace Week6;
//Program.cs’de aşağıdaki adımları yapınız:
//o Sistem nesnesi oluşturun.
//o 2 müşteri ekleyin.
//o 2 sürücü ekleyin.
//o Menüye 3 ürün ekleyin.
//o Menü gösterin.
//o 1 sipariş oluşturun.
//o Siparişe 2 ürün ekleyin.
//o Sürücü ataması yapın.
//o Siparişi yazdırın.
class Program
{
    static void Main()
    {
        var restaurantSystem = new RestaurantSystem();
        // Add customers
        restaurantSystem.RegisterCustomer("Alice", "alice12@gmail.com");
        restaurantSystem.RegisterCustomer("James", "james85@gmail.com");
        // Add drivers
        restaurantSystem.AddDriver("Kevin");
        restaurantSystem.AddDriver("Robert");
        // Add menu items
        restaurantSystem.AddMenuItem(new Drinkable("Coke", 10));
        restaurantSystem.AddMenuItem(new Eatable("Burger", 35));
        restaurantSystem.AddMenuItem(new Eatable("Fries", 20));
        restaurantSystem.AddMenuItem(new Drinkable("Juice", 15));
        // Show menu
        restaurantSystem.ShowMenu();
        // Create order for first customer
        var customer = restaurantSystem.GetCustomer(1);
        var order = restaurantSystem.CreateOrder(customer, new List<int> { 0, 1 });
        var customer2 = restaurantSystem.GetCustomer(2);
        var order2 = restaurantSystem.CreateOrder(customer2, new List<int> { 1, 2, 3 });
        // Assign driver
        var driver = restaurantSystem.AssignDriver();
        Console.WriteLine($"Assigned Driver: {driver.Name}");
        // Display order info
        order.DisplayInfo();
        order2.DisplayInfo();
    }
}