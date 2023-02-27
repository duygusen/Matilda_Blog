namespace Matilda_HW.Models;

public class Posts
{
    public int id { get; set; }
    public string title { get; set; }
    public string body { get; set; }
}

public class PostCollection
{
    public List<Posts> Posts { get; set; }

}


