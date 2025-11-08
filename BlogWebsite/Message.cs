namespace BlogWebsite;

public class Message
{
    public int MessageID { get; set; }
    public Author Author { get; set; }
    public string Descritption { get; set; }
    public DateTime SendDate { get; set; }
    public string ToString()
    { }
}

