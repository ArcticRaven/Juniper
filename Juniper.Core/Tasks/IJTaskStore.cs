using Juniper.Core.Tagging;

namespace Juniper.Core.Tasks;

public interface IJTaskStore
{
    JTask? Get(Guid id);

    // Query
    IReadOnlyList<JTask> Query(TaskQuery query);

    // CRUD
    bool Insert(JTask jTask);
    bool Update(JTask jTask);
    bool Delete(Guid id);
}

public sealed record TaskQuery
{
    public Guid? OwnerId { get; init; }
    public Guid? ProjectId { get; init; }

    public TaskStatus? Status { get; init; }
    public TagId? TagId { get; init; }

    public DateTimeOffset? DueBefore { get; init; }

    public int? Limit { get; init; }
    public int? Offset { get; init; }
}