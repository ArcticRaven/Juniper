namespace Juniper.Core.Events.System;

public interface IEvent
{
    Guid EventId { get; }
    DateTime Timestamp { get; }
    Guid SourceDeviceId { get; }
    string EventType { get; }
}

public interface IEvent<TPayload> : IEvent
{
    TPayload Payload { get; }
}