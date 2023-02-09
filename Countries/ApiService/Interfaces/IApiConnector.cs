namespace Countries.ApiService.Interfaces;

public interface IApiConnector<T>
{
    Task<T?> GetAsync(string requestUri);

    Task<IList<T>?> FindAsync(string requestUri);
}