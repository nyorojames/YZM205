namespace BlogWebsite;
public class Author
{
    public int AuthorId { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public string? Password { private get; set; }
    public string ToString()
    {
        return $" Name {Name} Surname {Surname}";
    }
}

