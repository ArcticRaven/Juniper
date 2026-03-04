using Juniper.Core.Notes;
using Juniper.Core.Tagging;

namespace Juniper.Core.Projects;

public sealed record Project
{
    Guid Id { get; init; }
    Guid? ParentId { get; init; }
    string Name { get; init; }
    string? Description { get; init; }                              // Optional
    ISet<TagId> Tags { get; init; } = new HashSet<TagId>();
    
    ISet<string> Aliases { get; init; } = new HashSet<string>();    // Reference Names
    
    public ProjectStatus Status { get; init; } = ProjectStatus.Active;
    public ProjectVisibility Visibility { get; init; } = ProjectVisibility.Private;
    
    public IDictionary<Guid, AccessLevel> AccessLevels { get; init; }
        = new Dictionary<Guid, AccessLevel>();                      // Establish people who can access a project
    
    public DateTimeOffset CreationDate { get; init; }
    public DateTimeOffset LastUpdateDate { get; init; }
    public DateTimeOffset LastAccessDate { get; init; }             // staleness detection
    
    
    
    ISet<Guid> Notes { get; init; } = new HashSet<Guid>();          // Project Notes
    ISet<Guid> Collaborators { get; init; } = new HashSet<Guid>();  // Project Contacts
    ISet<Guid> CalenderEvents { get; init; } = new HashSet<Guid>(); // Scheudled Events related to a project
    
    
}

public enum ProjectStatus
{
    Active,
    Paused,
    Archived,
    Research,
    Blocked,
    Planning
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

public enum ProjectTag
{
    
}