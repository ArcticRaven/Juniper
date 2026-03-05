using Juniper.Core.Tagging;

namespace Juniper.Core.Projects;

public sealed record Project : ITaggable
{
    public Guid Id { get; init; }
    public Guid? ParentId { get; init; }
    public Guid OwnerId { get; set; }

    public string Name { get; init; } = "";
    public string? Description { get; init; }
    public ISet<string> Aliases { get; init; } = new HashSet<string>();

    // Universal tags
    public ISet<TagId> TagIds { get; init; } = new HashSet<TagId>();
    
    // Strict state + mesh visibility
    public ProjectStatus Status { get; init; } = ProjectStatus.Active;
    public ProjectVisibility Visibility { get; init; } = ProjectVisibility.Private;

    // contactId -> access level 
    public IDictionary<Guid, AccessLevel> Collaborators { get; init; }
        = new Dictionary<Guid, AccessLevel>();

    // Timestamps
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset? UpdatedAt { get; init; }
    public DateTimeOffset? LastOpenedAt { get; init; } // staleness detection

    // Edges
    public ISet<Guid> NoteIds { get; init; } = new HashSet<Guid>();
    public ISet<Guid> CalendarEntryIds { get; init; } = new HashSet<Guid>();
    public ISet<Guid> TaskIds { get; init; } = new HashSet<Guid>();
    
    //todo - figure out Project Storage, Sync, Archive, etc. Link into Git? GitMonitor? idk bruh.
}

public enum ProjectStatus
{
    Planning,
    Research,
    Active,
    Paused,
    Blocked,
    Archived
}

public enum ProjectVisibility
{
    Private,   // Only the owning profile
    Mesh       // Visible to all users/profiles on this Juniper mesh
}

public enum AccessLevel
{
    Owner,
    Editor,
    ReadOnly
}