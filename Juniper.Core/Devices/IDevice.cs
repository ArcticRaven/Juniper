namespace Juniper.Core.Devices;

public interface IDevice
{
    Guid DeviceId { get; }
    string Alias { get; }
    DeviceType DeviceType { get; }
    TrustLevel Trust { get; }
    Guid OwnerId { get; }
    IReadOnlyList<CapabilityType> Capabilities { get; }
}