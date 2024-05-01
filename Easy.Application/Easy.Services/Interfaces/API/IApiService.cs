namespace Easy.Services.Interfaces.API
{
    public interface IApiService
    {
        Task<string> Post(string url, object objCreate);
        Task<string> Put(string url, object objUpdate);
        Task<string> Get(string url);
    }
}
