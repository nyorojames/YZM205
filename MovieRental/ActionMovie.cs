namespace MovieRental;

public class ActionMovie : Movie
{
    public string Rating { get; set; }
    public ActionMovie(string title, decimal price, string rating)
        : base(title, price)
    {
        Rating = rating;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Action: {Title} - {Price:C} (Rating: {Rating})");
    }
}

