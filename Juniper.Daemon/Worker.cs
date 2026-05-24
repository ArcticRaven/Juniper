namespace Juniper.Daemon;

/// <summary>
/// The Juniper background daemon. Responsible for running scheduled automations,
/// background sync, and other node-level work independent of the API server.
/// </summary>
public class Worker(ILogger<Worker> logger) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("Juniper daemon starting.");

        while (!stoppingToken.IsCancellationRequested)
        {
            await TickAsync(stoppingToken);
            await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
        }

        logger.LogInformation("Juniper daemon stopping.");
    }

    private Task TickAsync(CancellationToken cancellationToken)
    {
        // TODO: dispatch Soul tick, run pending automations, sync integrations
        return Task.CompletedTask;
    }
}
