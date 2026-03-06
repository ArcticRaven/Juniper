using Juniper.Core.Tagging;

namespace Juniper.Core.Tasks;

public interface IJTaskStore
{
    Task<JTask?> GetAsync(Guid id);

    // Query
    Task<IReadOnlyList<JTask>> QueryAsync(TaskQuery query);

    // CRUD
    Task InsertAsync(JTask jTask);
    Task UpdateAsync(JTask jTask);
    Task DeleteAsync(Guid taskId);
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