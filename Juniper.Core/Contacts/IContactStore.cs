using Juniper.Core.Tagging;

namespace Juniper.Core.Contacts;

public interface IContactStore
{
    Task<Contact?> GetAsync(Guid id);

    // filtering
    Task<IReadOnlyList<Contact>> QueryAsync(ContactQuery query);
    Task<IReadOnlyList<ContactSearchResult>> SearchByNameAsync(ContactNameQuery query);

    // CRUD
    Task InsertAsync(Contact contact);
    Task UpdateAsync(Contact contact);
    Task DeleteAsync(Guid contactId);
}

public sealed record ContactQuery
{
    public TagId? TagId { get; init; }
    public Relationship? Relationship { get; init; }
    public int? Limit { get; init; }
    public int? Offset { get; init; }
}

public sealed record ContactNameQuery
{
    public string SearchTerm { get; init; } = "";
    public bool ExactMatchOnly { get; init; }
    public bool IncludeAliases { get; init; } = true;
    public bool IncludeEmails { get; init; } = true;
    public int? Limit { get; init; }
    public int? Offset { get; init; }
}

public sealed record ContactSearchResult
{
    public Contact Contact { get; init; } = null!;
    public double Score { get; init; }
    public string MatchedField { get; init; } = "";
}