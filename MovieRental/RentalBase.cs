using System.Collections.Generic;

namespace MovieRental;

public abstract class RentalBase
{
    public int Id { get; set; }
    public RentalStatus Status { get; set; }
    protected readonly List<Movie> Movies;

    protected RentalBase(int id)
    {
        Id = id;
        Movies = new List<Movie>();
    }
}

public enum RentalStatus
{
    Pending,
    Active,
    Completed
}

