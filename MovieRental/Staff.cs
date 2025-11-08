namespace MovieRental;

public class Staff : Person
{
    public int StaffId { get; set; }
    public int AssignedRentals { get; private set; }
    public Staff(string name, string email, int staffId)
        : base(name, email)
    {
        StaffId = staffId;
        AssignedRentals = 0;
    }

    public void AssignRental()
    {
        AssignedRentals++;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Staff: {Name}, Assigned Rentals: {AssignedRentals}");
    }
}
