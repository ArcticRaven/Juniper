namespace Juniper.Core.Events.Library.Lifetime;

public sealed record ConnectingPayload
{
    public Guid DeviceId { get; init; }
    public string? Details { get; init; }
}

public sealed record ConnectedPayload
{
    public Guid DeviceId { get; init; }
    public string? Details { get; init; }
}

public sealed record DegradedPayload
{
    public Guid DeviceId { get; init; }
    public string Reason { get; init; } = "";
}