using Juniper.Core.Events.System;

namespace Juniper.Core.Events.Library.Lifetime;

public record ConnectingEvent : IEvent<ConnectingPayload>
{
    public Guid EventId { get; init;}
    public DateTime Timestamp { get; init;}
    public Guid SourceDeviceId { get; init;}
    public string EventType { get; init;}
    public ConnectingPayload Payload { get; init;}
}