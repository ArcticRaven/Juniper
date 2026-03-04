namespace Juniper.Core.Notes;

public enum NoteAttachmentType
{
    Image,
    Audio
}

public readonly record struct NoteAttachment
{
    public NoteAttachmentType Type { get; init; }
    public string Uri { get; init; } // file path, blob uri, etc.
    public string? MimeType { get; init; } // may not be known at creation
}