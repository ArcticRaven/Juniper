namespace Juniper.Core.Tagging;

public interface ITaggable
{
    ISet<TagId> TagIds { get; }
}