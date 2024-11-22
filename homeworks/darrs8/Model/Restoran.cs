namespace darrs8.Model;

public class Restoran
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Describtion { get; set; }
    public string Location { get; set; }
    public string Menu { get; set; }
    public int Capasity { get; set; }
    public DateTime OpenedDay { get; set; }
}
