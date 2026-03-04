using Juniper.Core.Notes;

namespace Juniper.Core.Contacts;

public sealed record Contact
{
    public Guid Id { get; init; }

    // Identity
    public string FirstName { get; set; } = "";
    public string? LastName { get; set; }

    public string FullName =>
        string.IsNullOrWhiteSpace(LastName)
            ? FirstName
            : $"{FirstName} {LastName}";

    public ISet<string> Aliases { get; init; } = new HashSet<string>();

    // Contact
    public string? Email { get; set; }
    public string? Phone { get; set; }

    public IDictionary<Socials, List<string>> SocialAccounts { get; init; }
        = new Dictionary<Socials, List<string>>();

    public IDictionary<string, Address> Addresses { get; init; }
        = new Dictionary<string, Address>();

    // Relationships
    public Relationship Relation { get; set; } = Relationship.Unknown;

    // Other contact id -> relationship to that contact
    public IDictionary<Guid, Relationship> Connections { get; init; }
        = new Dictionary<Guid, Relationship>();

    // Projects, Notes, and Events
    public ISet<Guid> ProjectIds { get; init; } = new HashSet<Guid>();
    public ISet<Guid> TaskIds { get; init; } = new HashSet<Guid>();
    public ISet<Guid> EventIds { get; init; } = new HashSet<Guid>();
    public IList<Note> Notes { get; init; } = new List<Note>();
}