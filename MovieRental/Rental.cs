namespace MovieRental;

public class Rental : RentalBase
{
    public Rental(int id) : base(id) { }
    public void AddMovie(Movie movie)
    {
        if (movie == null) throw new ArgumentNullException(nameof(movie), "Movie cannot be null");
        var existingMovie = Movies.FirstOrDefault(m => m.Title == movie.Title);
        if (existingMovie != null)
            throw new InvalidOperationException($"Movie '{movie.Title}' is already in the rental.");
        Movies.Add(movie);
    }
    public decimal CalculateTotal() => Movies.Sum(m => m.Price);
    public void DisplayRental()
    {
        Console.WriteLine($"--- Rental #{Id} ---");
        foreach (var movie in Movies)
            movie.DisplayInfo();
        Console.WriteLine($"Total: {CalculateTotal():C}");
        Console.WriteLine($"Status: {Status}");
    }
}

