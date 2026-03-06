namespace Juniper.Core.Tagging;

public interface ITagStore
{
    Task<Tag?> GetAsync(TagId id);

    // Tag queries
    Task<IReadOnlyList<Tag>> SearchByNameAsync(string query);
    Task<IReadOnlyList<Tag>> QueryAsync(TagQuery query);

    // Category queries
    Task<IReadOnlyList<Tag>> GetByCategoryAsync(string category);
    Task<IReadOnlyList<string>> GetCategoriesAsync();

    // CRUD-ish
    Task<Tag> CreateAsync(string name, string? hexColor = null, string? category = null);
    Task UpsertAsync(Tag tag);

    Task<Tag> GetOrCreateAsync(string name, string? hexColor = null, string? category = null);
}

public sealed record TagQuery
{
    public string? Name { get; init; }
    public string? Category { get; init; }

    public int? Limit { get; init; }
    public int? Offset { get; init; }
}