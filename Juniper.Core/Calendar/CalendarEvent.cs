using Juniper.Core.Contacts;

namespace Juniper.Core.Calendar;

public sealed record CalendarEvent
{
    public Guid Id { get; init; }

    public EventKind Kind { get; init; } = EventKind.TimeBlock;
    public EventVisibility Visibility { get; set; } = EventVisibility.Private;

    public string Title { get; init; } = "";
    public string? Description { get; init; }

    public string? Location { get; init; }
    public CalendarContext Context { get; init; }

    public DateTimeOffset StartsAt { get; init; }
    public DateTimeOffset? EndsAt { get; init; } // reminders will not use an EndsAt

    public bool IsAllDay { get; init; }
    public bool IsAutomated { get; init; }

    public ISet<Guid> ContactIds { get; init; } = new HashSet<Guid>();
    public ISet<Guid> ProjectIds { get; init; } = new HashSet<Guid>();
    public ISet<Guid> TaskIds { get; init; } = new HashSet<Guid>();
    public ISet<Guid> NoteIds { get; init; } = new HashSet<Guid>();
}

public enum EventVisibility
{
    Private,
    Public
}

public enum EventKind
{
    TimeBlock,
    Reminder
}
