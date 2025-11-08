namespace BlogWebsite;

public class Post: IComparable<Post>
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public Author Author { get; set; }
    public string Details { get; set; }
    public DateTime PublishDate { get; set; }
    public decimal Duration { get; set; }
    public DateTime EditDate { get; set; }
    public int LikeCount { get; set; }
    public List<Message> Message;
    public void AddLike()
    { }

    public int CompareTo (Post postid)
    {
        return this.PostId.CompareTo(postid);
    }

  
}

