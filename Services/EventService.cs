using EventEase.Models;

namespace EventEase.Services;

public class EventService
{
    private readonly List<Event> _events = new();
    private int _nextEventId = 1;
    private int _nextRegistrationId = 1;

    public EventService()
    {
        InitializeSampleData();
    }

    private void InitializeSampleData()
    {
        _events.AddRange(new[]
        {
            new Event
            {
                Id = _nextEventId++,
                Name = "Tech Conference 2025",
                Description = "Join us for the biggest technology conference of the year featuring AI, cloud computing, and innovative startups.",
                Date = DateTime.Now.AddDays(30),
                Location = "San Francisco Convention Center",
                MaxAttendees = 500,
                CurrentAttendees = 347,
                Category = "Technology",
                ImageUrl = "https://images.pexels.com/photos/2774556/pexels-photo-2774556.jpeg?auto=compress&cs=tinysrgb&w=800"
            },
            new Event
            {
                Id = _nextEventId++,
                Name = "Summer Music Festival",
                Description = "Experience three days of non-stop music with world-renowned artists across multiple stages.",
                Date = DateTime.Now.AddDays(60),
                Location = "Central Park Amphitheater",
                MaxAttendees = 2000,
                CurrentAttendees = 1850,
                Category = "Music",
                ImageUrl = "https://images.pexels.com/photos/1105666/pexels-photo-1105666.jpeg?auto=compress&cs=tinysrgb&w=800"
            },
            new Event
            {
                Id = _nextEventId++,
                Name = "Business Leadership Summit",
                Description = "Network with industry leaders and learn cutting-edge business strategies for modern enterprises.",
                Date = DateTime.Now.AddDays(45),
                Location = "Downtown Business District",
                MaxAttendees = 300,
                CurrentAttendees = 156,
                Category = "Business",
                ImageUrl = "https://images.pexels.com/photos/1181396/pexels-photo-1181396.jpeg?auto=compress&cs=tinysrgb&w=800"
            },
            new Event
            {
                Id = _nextEventId++,
                Name = "Fitness & Wellness Expo",
                Description = "Discover the latest in fitness technology, nutrition, and wellness practices from industry experts.",
                Date = DateTime.Now.AddDays(20),
                Location = "Metro Sports Complex",
                MaxAttendees = 800,
                CurrentAttendees = 423,
                Category = "Health",
                ImageUrl = "https://images.pexels.com/photos/1552242/pexels-photo-1552242.jpeg?auto=compress&cs=tinysrgb&w=800"
            },
            new Event
            {
                Id = _nextEventId++,
                Name = "Art & Design Workshop",
                Description = "Hands-on creative workshop exploring contemporary art techniques and digital design tools.",
                Date = DateTime.Now.AddDays(15),
                Location = "Creative Arts Studio",
                MaxAttendees = 50,
                CurrentAttendees = 48,
                Category = "Arts",
                ImageUrl = "https://images.pexels.com/photos/1839919/pexels-photo-1839919.jpeg?auto=compress&cs=tinysrgb&w=800"
            },
            new Event
            {
                Id = _nextEventId++,
                Name = "Food & Wine Tasting",
                Description = "Sample exquisite cuisines and premium wines from award-winning chefs and sommeliers.",
                Date = DateTime.Now.AddDays(10),
                Location = "Harbor View Restaurant",
                MaxAttendees = 120,
                CurrentAttendees = 67,
                Category = "Food",
                ImageUrl = "https://images.pexels.com/photos/1267320/pexels-photo-1267320.jpeg?auto=compress&cs=tinysrgb&w=800"
            }
        });
    }

    public List<Event> GetAllEvents() => _events.OrderBy(e => e.Date).ToList();

    public Event? GetEventById(int id) => _events.FirstOrDefault(e => e.Id == id);

    public bool RegisterForEvent(int eventId, Registration registration)
    {
        var eventItem = GetEventById(eventId);
        if (eventItem == null || eventItem.IsFull || eventItem.AvailableSpots < registration.NumberOfTickets)
        {
            return false;
        }

        registration.Id = _nextRegistrationId++;
        registration.EventId = eventId;
        registration.RegistrationDate = DateTime.Now;

        eventItem.Registrations.Add(registration);
        eventItem.CurrentAttendees += registration.NumberOfTickets;

        return true;
    }

    public List<Registration> GetEventRegistrations(int eventId)
    {
        var eventItem = GetEventById(eventId);
        return eventItem?.Registrations ?? new List<Registration>();
    }

    public void UpdateEvent(Event updatedEvent)
    {
        var index = _events.FindIndex(e => e.Id == updatedEvent.Id);
        if (index != -1)
        {
            _events[index] = updatedEvent;
        }
    }
}
