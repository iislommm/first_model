namespace dars9.model;

public class Post
{
    public int Likes { get; set; }
    public string OwnerName { get; set; }
    public List<string> Comments { get; set; } = new List<string>();
    public DateTime PostedTime { get; set; }
    public string Describtion { get; set; }
    public List<string> ViewerNames { get; set; } = new List<string>();
    public Guid Id { get; set; }
    public string Type { get; set; }
}
