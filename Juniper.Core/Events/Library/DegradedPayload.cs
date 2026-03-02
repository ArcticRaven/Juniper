namespace Juniper.Core.Events.Library;

public record DegradedPayload
{
    public Guid DeviceId { get; init; }
    public string Reason { get; init; }
}