using MongoDB.Bson.Serialization.Attributes;
using NodaTime;

namespace ConnorWyatt.EventSourcing.Subscriptions.Mongo;

public record SubscriptionCursor(
  [property: BsonId]
  string Id,
  string SubscriberName,
  string StreamName,
  ulong Position,
  Instant LastUpdated);
