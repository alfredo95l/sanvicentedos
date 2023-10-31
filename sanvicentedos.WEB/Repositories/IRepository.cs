namespace sanvicentedos.WEB.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        Task<HttpResponseWrapper<object>> Post<T>(string url, T modelo);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T modelo);
        Task<HttpResponseWrapper<object>> Delete(string url);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T modelo);
        Task<HttpResponseWrapper<TResponse>> Put<T, TResponse>(string url, T modelo);
    }
}
