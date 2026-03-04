namespace Juniper.Core.Tagging;

public interface ITagStore
{
    Tag? Get(Guid guid);
    
    IEnumerable<Tag> SearchByName(string query);
    
    Tag Create(String name, string? hexColor = null, string? category = null);
    void Upsert(Tag tag);
    
    Tag GetOrCreate(string name, string? hexColor = null, string? category = null);
}