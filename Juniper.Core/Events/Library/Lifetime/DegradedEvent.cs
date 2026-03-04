using Juniper.Core.Events.System;

namespace Juniper.Core.Events.Library.Lifetime;

public record DegradedEvent : IEvent<DegradedPayload>
{
    public Guid EventId { get; init; }
    public DateTime Timestamp { get; init; }
    public Guid SourceDeviceId { get; init;}
    public string EventType { get; init; }
    public DegradedPayload Payload { get; init;}
}