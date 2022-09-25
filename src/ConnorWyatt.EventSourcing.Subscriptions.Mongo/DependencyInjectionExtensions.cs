using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using NodaTime;

namespace ConnorWyatt.EventSourcing.Subscriptions.Mongo;

public static class DependencyInjectionExtensions
{
  public static IServiceCollection
    AddMongoSubscriptionCursorsRepository(this IServiceCollection services, string collectionName) =>
    services.AddTransient<ISubscriptionCursorsRepository>(
      serviceProvider => new MongoSubscriptionCursorsRepository(
        serviceProvider.GetRequiredService<IMongoDatabase>(),
        serviceProvider.GetRequiredService<IClock>(),
        collectionName));
}
