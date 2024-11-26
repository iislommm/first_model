using System.Runtime;

namespace dars9Event.model;

public class Event
{
    public Guid Id { get; set; }
    public int Guests { get; set; }
    public string Location { get; set; }
    public List<string> SpecialGuests { get; set; }
    public string Describtion { get; set; }
    public string Type { get; set; }
    public string OwnerName { get; set; }

}
