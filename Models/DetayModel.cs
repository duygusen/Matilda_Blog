namespace Matilda_HW.Models;

public class Comments
{
    public int id { get; set; }
    public string body { get; set; }
    public int postId { get; set; }
    public user user { get; set; }
}

public class user
{
    public int userid { get; set; }
    public string username { get; set; }
}

public class CommentsCollection
{
    public List<Comments> Comments { get; set; }

}
