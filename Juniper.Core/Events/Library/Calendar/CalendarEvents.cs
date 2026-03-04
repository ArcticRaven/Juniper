using Juniper.Core.Events.System;

namespace Juniper.Core.Events.Library.Calendar;

public static class CalendarEventTypes
{
    public const string Created = "calendar.entry.created";
    public const string Updated = "calendar.entry.updated";
    public const string Deleted = "calendar.entry.deleted";
}

public sealed record CalendarEntryCreatedEvent : IEvent<CalendarEntryUpsertPayload>
{
    public Guid EventId { get; init; }
    public DateTimeOffset Timestamp { get; init; }
    public Guid SourceDeviceId { get; init; }
    public string EventType { get; init; } = CalendarEventTypes.Created;

    public CalendarEntryUpsertPayload Payload { get; init; } = new();
}

public sealed record CalendarEntryUpdatedEvent : IEvent<CalendarEntryUpsertPayload>
{
    public Guid EventId { get; init; }
    public DateTimeOffset Timestamp { get; init; }
    public Guid SourceDeviceId { get; init; }
    public string EventType { get; init; } = CalendarEventTypes.Updated;

    public CalendarEntryUpsertPayload Payload { get; init; } = new();
}

public sealed record CalendarEntryDeletedEvent : IEvent<CalendarEntryDeletedPayload>
{
    public Guid EventId { get; init; }
    public DateTimeOffset Timestamp { get; init; }
    public Guid SourceDeviceId { get; init; }
    public string EventType { get; init; } = CalendarEventTypes.Deleted;

    public CalendarEntryDeletedPayload Payload { get; init; } = new();
}

// Payloads

public sealed record CalendarEntryUpsertPayload
{
    public Guid CalendarEntryId { get; init; }
    public Juniper.Core.Calendar.CalendarEntry Entry { get; init; } = new();
}

public sealed record CalendarEntryDeletedPayload
{
    public Guid CalendarEntryId { get; init; }
}