namespace MovieRental;

public abstract class Movie
{
    public string? Title { get; set; }
    public decimal Price { get; set; }
    public abstract void DisplayInfo();
    public Movie(string title, decimal price)
    {
        Title = title;
        Price = price;
    }
}
