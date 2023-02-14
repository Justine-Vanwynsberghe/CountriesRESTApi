namespace Countries.StateManagement;

public class UnSubscriber : IDisposable
{
    private readonly ObservingComponent _observer;
    private readonly List<ObservingComponent> _observers;

    public UnSubscriber(List<ObservingComponent> observers, ObservingComponent observer)
    {
        _observer = observer;
        if (_observer.Subscriptions == null) _observer.Subscriptions = new List<IDisposable>();
        _observer.Subscriptions.Add(this);
        _observers = observers;
    }

    public void Dispose()
    {
        if (_observers.Contains(_observer))
            _observers.Remove(_observer);
    }
}