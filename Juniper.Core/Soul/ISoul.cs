using Juniper.Core.Devices;

namespace Juniper.Core.Soul;

public interface ISoul
{
    IDevice Device { get; }
    SoulState State { get; }
    
    Task SetupAsync(CancellationToken cancellationToken);  // initialise, load config, register capabilities
    Task StartAsync(CancellationToken cancellationToken);  // begin running, start services
    Task TickAsync(CancellationToken cancellationToken);   // main loop iteration
    Task StopAsync(CancellationToken cancellationToken);   // shutdown
}