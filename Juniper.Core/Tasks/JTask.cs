using Juniper.Core.Capabilities;
using Juniper.Core.Tagging;

namespace Juniper.Core.Tasks;

public sealed record JTask : ITaggable
{
    // JTask Identity
    public Guid Id { get; init; } = Guid.NewGuid();
    public string? Title { get; init; }
    public Guid? OwnerId  { get; set; }
    public Guid? DeviceId  { get; init; }
    public Guid? TargetNodeId { get; init; }      // If JTask should be delegated to another device
    // Universal tags
    public ISet<TagId> TagIds { get; init; } = new HashSet<TagId>();
    
    // Requirements
    public ISet<CapabilityType> RequiredCapabilities { get; init; } = new HashSet<CapabilityType>();
    public string Payload { get; init; } = string.Empty;
    public byte[]? Data { get; init; }
    
    // JTask Lifetime
    public TaskStatus Status { get; set; } = TaskStatus.Pending;
    public TaskPriority Priority { get; set; } =  TaskPriority.Normal;
    
    // JTask Data Marks
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? ScheduledAt { get; init; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? CompletedAt { get; set; }
    public ISet<Guid> BlockedByTasks { get; init; } = new HashSet<Guid>();
    public Guid? CompletedBy { get; set; }
    
    // JTask Relations
    public ISet<Guid> RelatedTasks { get; init; } = new HashSet<Guid>();
    public ISet<Guid> NoteIds { get; init; } = new HashSet<Guid>();
    public ISet<Guid> CalendarEntryIds { get; init; } = new HashSet<Guid>();
    public ISet<Guid> SubtaskIds { get; init; } = new HashSet<Guid>();
}

public enum TaskStatus
{
    Pending,
    InProgress,
    Blocked,
    Complete,
    Cancelled
}

public enum TaskPriority
{
    Normal,
    Low,
    High,
    Critical
}