namespace Juniper.Core.Tagging;

public interface ITagStore
{
    Tag? Get(TagId id);

    // Tag queries
    IEnumerable<Tag> SearchByName(string query);

    // Category queries
    
    // todo - Fuzzy Matching~~ 
    IEnumerable<Tag> GetByCategory(string category);
    IEnumerable<string> GetCategories();

    // meow
    Tag Create(string name, string? hexColor = null, string? category = null);
    void Upsert(Tag tag);

    Tag GetOrCreate(string name, string? hexColor = null, string? category = null);
}