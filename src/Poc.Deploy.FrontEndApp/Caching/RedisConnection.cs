namespace Poc.Deploy.FrontEndApp.Caching
{
    using System;

    using StackExchange.Redis;

    public class RedisConnection
    {
        private readonly Lazy<ConnectionMultiplexer> connectionMultiplexer;

        private readonly Lazy<IDatabase> database;

        public RedisConnection(string connectionString ="localhost", int database = 0)
        {
            this.connectionMultiplexer = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(connectionString));

            this.database = new Lazy<IDatabase>(() => connectionMultiplexer.Value.GetDatabase(database));
        }

        public IDatabase Database
        {
            get
            {
                return this.database.Value;
            }
        }

    }
}