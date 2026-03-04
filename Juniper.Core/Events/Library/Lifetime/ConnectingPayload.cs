using Juniper.Core.Devices;

namespace Juniper.Core.Events.Library.Lifetime;

public record ConnectingPayload
{
    public Guid DeviceId { get; init; }
    public string Alias { get; init; }
    public DeviceType DeviceType { get; init; }
    public IReadOnlyList<CapabilityType> Capabilities { get; init; }
}