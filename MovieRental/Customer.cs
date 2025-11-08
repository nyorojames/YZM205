namespace MovieRental;

public class Customer : Person
{
    public int CustomerId { get; set; }
    public int RentedMovies { get; set; }
    public Customer(string name, string email, int customerId)
        : base(name, email)
    {
        CustomerId = customerId;
        RentedMovies = 0;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Customer: {Name}, Email: {Email}, Rented Movies: {RentedMovies}");
    }

}
