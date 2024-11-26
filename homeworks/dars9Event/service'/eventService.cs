using dars9Event.model;

namespace dars9Event.service_;

public class eventService
{
    private List<Event> events;
    public eventService()
    {
        events = new List<Event>();
    }
    public Event AddEvent(Event newEvent)
    {
        events.Add(newEvent);
        return newEvent;
    }
    public List<Event> GetAllEvents()
    {
        return events;
    }

    public bool UpdateEvent(Event updateEvent)
    {
        for (var i = 0; i < events.Count; ++i)
        {
            if (events[i].Id == updateEvent.Id)
            {
                return true;
            }
        }
        return false;
    }
    public bool DeleteEvent(Guid eventId)
    {
        var exist = false;
        foreach (var eventcha in events)
        {
            if (eventcha.Id == eventId)
            {
                exist = true;
                break;
            }
        }
        return exist;
    }
    public Event GetById (Guid eventId)
    {
        foreach (var eventcha in events)
        {
            if (eventcha.Id == eventId)
            {
                return eventcha;
            }
        }
        return null;
    }
    public event AddViewerName (Event )

}