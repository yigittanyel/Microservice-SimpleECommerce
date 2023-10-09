using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Cache.CacheManager;
using CacheManager.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration.AddJsonFile("ocelot.json");

builder.Services.AddOcelot().AddCacheManager(x =>
{
    x.WithRedisConfiguration("redis",
            config =>
            {
                config.WithAllowAdmin()
                .WithDatabase(0)
                .WithEndpoint("localhost", 6379);
            })
    .WithJsonSerializer()
    .WithRedisCacheHandle("redis");
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseOcelot().Wait();

app.UseAuthorization();

app.MapControllers();

app.Run();
