namespace Countries.StateManagement;

public interface IObservable
{
    IDisposable Subscribe(ObservingComponent observer);
}