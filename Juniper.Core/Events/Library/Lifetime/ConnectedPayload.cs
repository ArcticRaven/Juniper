namespace Juniper.Core.Events.Library.Lifetime;

public record ConnectedPayload
{
    public Guid DeviceId { get; init; }
}