namespace Juniper.Core.Events.Library.Lifetime;

public record DegradedPayload
{
    public Guid DeviceId { get; init; }
    public string Reason { get; init; }
}