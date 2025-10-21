namespace EventEase.Services;

public class UserSessionService
{
    private string _userName = "Guest";
    private List<int> _registeredEventIds = new();
    private DateTime _sessionStart = DateTime.Now;

    public event Action? OnStateChanged;

    public string UserName
    {
        get => _userName;
        set
        {
            _userName = value;
            NotifyStateChanged();
        }
    }

    public List<int> RegisteredEventIds => _registeredEventIds;

    public TimeSpan SessionDuration => DateTime.Now - _sessionStart;

    public void AddRegisteredEvent(int eventId)
    {
        if (!_registeredEventIds.Contains(eventId))
        {
            _registeredEventIds.Add(eventId);
            NotifyStateChanged();
        }
    }

    public bool IsRegisteredForEvent(int eventId) => _registeredEventIds.Contains(eventId);

    public int TotalRegistrations => _registeredEventIds.Count;

    private void NotifyStateChanged() => OnStateChanged?.Invoke();
}
