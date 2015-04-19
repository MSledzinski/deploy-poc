namespace Poc.Deploy.FrontEndApp.Caching
{
    using Newtonsoft.Json;

    public class RedisCacheProxy : ICacheStoreProxy
    {
        private readonly RedisConnection connection;

        public RedisCacheProxy(RedisConnection connection)
        {
            this.connection = connection;
        }

        public void SetWithKey<T>(string key, T data) where T : class
        {
            var objectString = JsonConvert.SerializeObject(data);
            connection.Database.StringSet(key, objectString);
        }

        public bool TryGetWithKey<T>(string key, out T value) where T : class
        {
            var cached = connection.Database.StringGet(key);
            // really bad code :) - should be null object pattern, or maybe monad :)
            value = cached.HasValue ? JsonConvert.DeserializeObject<T>(cached.ToString()) : null;
            return value != null;
        }

        public void InvalidateKey(string key)
        {
            connection.Database.KeyDelete(key);
        }
    }
}