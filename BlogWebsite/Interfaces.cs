namespace BlogWebsite;

public interface IBlogRepository
{
    public void AddPost(Post post);
    public Post DeletePost(int id);
    public Post GetPostById(int id);
    public List<Post> GetAllPosts();
    public void UpdatePost(int id, string detail, decimal duration);

}

public interface IAuthorRepository
{
    public void AddUser(Author post);
    public Author DeleteAuthor(int id);
    public Author GetAuthorById(int id);
}
