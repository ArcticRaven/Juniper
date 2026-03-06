using Juniper.Core.Tagging;

namespace Juniper.Core.Notes;

public interface INoteStore
{
    Task<Note?> GetAsync(Guid id);

    // Query
    Task<IReadOnlyList<Note>> QueryAsync(NoteQuery query);

    // CRUD
    Task InsertAsync(Note note);
    Task UpdateAsync(Note note);
    Task DeleteAsync(Guid noteId);
}

public sealed record NoteQuery
{
    public Guid? OwnerId { get; init; }
    public Guid? ProjectId { get; init; }
    public TagId? TagId { get; init; }
    public string? SearchTerm { get; init; }
    public DateTimeOffset? CreatedAfter { get; init; }
    public DateTimeOffset? CreatedBefore { get; init; }
    public int? Limit { get; init; }
    public int? Offset { get; init; }
    public string? SortBy { get; init; }
    public string? SortOrder { get; init; }
}