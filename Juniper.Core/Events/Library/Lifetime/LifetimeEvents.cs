using Juniper.Core.Events.System;

namespace Juniper.Core.Events.Library.Lifetime;

public static class LifetimeEventTypes
{
    public const string Connecting = "lifetime.connecting";
    public const string Connected  = "lifetime.connected";
    public const string Degraded   = "lifetime.degraded";
}

public sealed record ConnectingEvent : IEvent<ConnectingPayload>
{
    public Guid EventId { get; init; }
    public DateTimeOffset Timestamp { get; init; }
    public Guid SourceDeviceId { get; init; }
    public string EventType { get; init; } = LifetimeEventTypes.Connecting;

    public ConnectingPayload Payload { get; init; } = new();
}

public sealed record ConnectedEvent : IEvent<ConnectedPayload>
{
    public Guid EventId { get; init; }
    public DateTimeOffset Timestamp { get; init; }
    public Guid SourceDeviceId { get; init; }
    public string EventType { get; init; } = LifetimeEventTypes.Connected;

    public ConnectedPayload Payload { get; init; } = new();
}

public sealed record DegradedEvent : IEvent<DegradedPayload>
{
    public Guid EventId { get; init; }
    public DateTimeOffset Timestamp { get; init; }
    public Guid SourceDeviceId { get; init; }
    public string EventType { get; init; } = LifetimeEventTypes.Degraded;

    public DegradedPayload Payload { get; init; } = new();
}