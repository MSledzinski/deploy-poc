namespace Poc.Deploy.FrontEndApp.Caching
{
    public interface ICacheStoreProxy
    {
        void SetWithKey<T>(string key, T data) where T : class;

        bool TryGetWithKey<T>(string key, out T value) where T : class;

        void InvalidateKey(string key);
    }
}