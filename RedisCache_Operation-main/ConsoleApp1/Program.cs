// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using Microsoft.Extensions.DependencyInjection;
using RedisCacheHelper;
using StackExchange.Redis;

Console.WriteLine("Hello, World!");
// Replace with your AWS Elasticache Redis endpoint
var redisEndpoint = "localhost:6379";// "your-redis-endpoint.amazonaws.com:6379";

// Setup dependency injection
var serviceProvider = new ServiceCollection()
    .AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect(redisEndpoint))
    .AddSingleton<IRedisCacheService, RedisCacheService>()
    .BuildServiceProvider();

// Resolve the RedisCacheService
var cacheService = serviceProvider.GetService<IRedisCacheService>();

// Example usage
await cacheService.SetAsync("myKey", "myValue", TimeSpan.FromMinutes(10));
Console.WriteLine($"Value set cache");
var value = await cacheService.GetAsync<string>("myKey");
Console.WriteLine($"Value from cache: {value}");

await cacheService.RemoveAsync("myKey");
Console.WriteLine("Value removed from cache");

Console.ReadLine();