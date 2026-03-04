namespace Juniper.Core.Notes;

public sealed record Note
{
    public Guid Id { get; init; }
    
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset UpdatedAt { get; init; }

    public string Title { get; init; } = "";
    public string Markdown { get; init; } = "";
    
    public IList<NoteAttachment> Attachments { get; init; } = new List<NoteAttachment>();
}