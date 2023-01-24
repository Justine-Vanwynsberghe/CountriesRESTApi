namespace Countries.ApiService.Interfaces
{
    public interface IApiConnector<T>
    {
        Task<T?> GetAsync(string requestUri);
    }
}
