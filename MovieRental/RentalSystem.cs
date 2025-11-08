namespace MovieRental;

public class RentalSystem
{
    private List<Customer> _customers;
    private List<Staff> _staff;
    private List<Movie> _movies;
    private List<Rental> _rentals;
    public RentalSystem()
    {
        _customers = new List<Customer>();
        _staff = new List<Staff>();
        _movies = new List<Movie>();
        _rentals = new List<Rental>();
    }

    private int customerCounter = 1;
    private int staffCounter = 1;
    private int rentalCounter = 1;

    public void RegisterCustomer(Customer customer)
    {
        var existingCustomer = _customers.FirstOrDefault(c => c.Email == customer.Email);
        if(existingCustomer != null)
        {
            Console.WriteLine($"Customer with email {customer.Email} already registered.");
            return;
        }
        _customers.Add(customer);
        customer.CustomerId = customerCounter++;
    }

    public void AddStaff(Staff staff)
    {
        var existingStaff = _staff.FirstOrDefault(s => s.Email == staff.Email);
        if(existingStaff != null)
        {
            Console.WriteLine($"Staff with email {staff.Email} already registered.");
            return;
        }
        _staff.Add(staff);
        staff.StaffId = staffCounter++;
    }

    public void AddMovie(Movie movie)
    {
        var existingMovie = _movies.FirstOrDefault(m => m.Title == movie.Title);
        if(existingMovie != null)
        {
            Console.WriteLine($"Movie '{movie.Title}' already exists in the catalog.");
            return;
        }
        _movies.Add(movie);
    }

    public void ShowMovies()
    {
        Console.WriteLine("\n--- Movie Catalog ---");
        foreach (var m in _movies)
            m.DisplayInfo();
    }

    public Rental CreateRental(int customerId)
    {
        var customer = _customers.FirstOrDefault(c => c.CustomerId == customerId);
        if (customer == null)
        {
            throw new InvalidOperationException($"Customer with id {customerId} not found.");
        }
        var rental = new Rental(rentalCounter++);
        rental.Status = RentalStatus.Active;
        _rentals.Add(rental);

        customer.RentedMovies++;
        Console.WriteLine($"Rental #{rental.Id} created for Customer {customer.Name}");
        return rental;
    }

    public void AssignStaff()
    {
        if (!_staff.Any())
        {
            Console.WriteLine("No staff available to assign.");
            return;
        }
        var available = _staff.MinBy(s => s.AssignedRentals);
        if (available == null)
        {
            Console.WriteLine("No staff available to assign.");
            return;
        }
        available.AssignRental();
        Console.WriteLine($"Assigned Staff: {available.Name}");
    }

    public void ShowRentals()
    {
        Console.WriteLine("\n--- All Rentals ---");
        foreach (var r in _rentals)
            r.DisplayRental();
    }
}

