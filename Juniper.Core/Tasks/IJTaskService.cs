namespace Juniper.Core.Tasks;

public interface IJTaskService
{
    public void Init();
    public void Tick(DateTimeOffset now);
    public void Result(TaskResult result);
    public void SendTask(Guid targetNodeId, JTask jTask);
    public void SendResult(Guid targetNodeId, TaskResult result);
    public void ReceiveTask(JTask jTask);
    public void ReceiveResult(TaskResult result);
    public void Shutdown();
}

public sealed record TaskResult
{
    public Guid TaskId { get; init; }
    public bool Success { get; init; }
    public string? Error { get; init; }
    public string? Output { get; init; }
    public byte[]? Data { get; init; }
}