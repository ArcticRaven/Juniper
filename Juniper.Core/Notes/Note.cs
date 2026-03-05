using Juniper.Core.Tagging;

namespace Juniper.Core.Notes;

public sealed record Note : ITaggable
{
    public Guid Id { get; init; }
    
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset UpdatedAt { get; init; }

    public string Title { get; init; } = "";
    public string Markdown { get; init; } = "";
    
    // Universal tags
    public ISet<TagId> TagIds { get; init; } = new HashSet<TagId>();
    
    public IList<NoteAttachment> Attachments { get; init; } = new List<NoteAttachment>();
}