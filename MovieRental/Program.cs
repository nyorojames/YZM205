namespace MovieRental;

class Program
{
    static void Main()
    {
        var system = new RentalSystem();

        system.RegisterCustomer(new Customer("Alice", "alice@mail.com", 1));
        system.RegisterCustomer(new Customer("Bob", "bob@mail.com", 2));

        system.AddStaff(new Staff("John", "john@store.com", 1));
        system.AddStaff(new Staff("Emma", "emma@store.com", 2));

        system.AddMovie(new ActionMovie("Inception", 15,  "PG-13"));
        system.AddMovie(new ComedyMovie ("Rush Hour", 10, 8));
        system.AddMovie(new ActionMovie ("Mad Max", 12, "R"));

        system.ShowMovies();

        var rental = system.CreateRental(1);
        rental.AddMovie(new ActionMovie ("Inception", 15, "PG-13"));
        rental.AddMovie(new ComedyMovie ("Rush Hour", 10, 8));
        rental.CalculateTotal();

        system.AssignStaff();
        rental.DisplayRental();
    }
}
