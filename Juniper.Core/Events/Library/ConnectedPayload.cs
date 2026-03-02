namespace Juniper.Core.Events.Library;

public record ConnectedPayload
{
    public Guid DeviceId { get; init; }
}