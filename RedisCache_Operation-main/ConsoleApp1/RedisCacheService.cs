using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //public interface IRedisCacheService
    //{
    //    Task<T> GetAsync<T>(string key);
    //    Task SetAsync<T>(string key, T value, TimeSpan? expiry = null);
    //    Task RemoveAsync(string key);
    //}

    //public class RedisCacheService : IRedisCacheService
    //{
    //    private readonly IConnectionMultiplexer _redis;
    //    private readonly IDatabase _database;

    //    public RedisCacheService(IConnectionMultiplexer redis)
    //    {
    //        _redis = redis;
    //        _database = _redis.GetDatabase();
    //    }

    //    public async Task<T> GetAsync<T>(string key)
    //    {
    //        var value = await _database.StringGetAsync(key);
    //        if (value.IsNullOrEmpty)
    //        {
    //            return default(T);
    //        }

    //        return JsonConvert.DeserializeObject<T>(value);
    //    }

    //    public async Task SetAsync<T>(string key, T value, TimeSpan? expiry = null)
    //    {
    //        var serializedValue = JsonConvert.SerializeObject(value);
    //        await _database.StringSetAsync(key, serializedValue, expiry);
    //    }

    //    public async Task RemoveAsync(string key)
    //    {
    //        await _database.KeyDeleteAsync(key);
    //    }
    //}
}
