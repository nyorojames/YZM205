namespace MovieRental;

public class ComedyMovie : Movie
{
    public int HumorLevel { get; set; }
    public ComedyMovie(string title, decimal price, int humorLevel)
        : base(title, price)
    {
        HumorLevel = humorLevel;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Comedy: {Title} - {Price:C} (Humor Level: {HumorLevel}/10)");
    }

}