namespace Countries.StateManagement;

public class CssState : IObservable
{
    private readonly List<ObservingComponent> _observers = new();

    public string? DialogCssCLass { get; set; } = "";
    public bool LightTheme { get; set; }


    public IDisposable Subscribe(ObservingComponent observer)
    {
        if (!_observers.Contains(observer)) _observers.Add(observer);

        return new UnSubscriber(_observers, observer);
    }

    private void NotifyStateChanged()
    {
        foreach (var observer in _observers.ToList()) observer.OnNext();
    }

    public void ToggleThemeSwitcher()
    {
        LightTheme = !LightTheme;
        DialogCssCLass = LightTheme ? "light-mode" : "";
        NotifyStateChanged();
    }
}