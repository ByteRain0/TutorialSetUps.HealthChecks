using HealthChecksExample.Infrastructure;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HealthChecksExample.HealthChecks;

public class CustomHealthCheck : IHealthCheck
{
    private readonly ILegacyService _legacyService;

    public CustomHealthCheck(ILegacyService legacyService)
    {
        _legacyService = legacyService;
    }

    public Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        var isHealthy = _legacyService.IsAlive();
        
        if (isHealthy)
        {
            return Task.FromResult(
                HealthCheckResult.Healthy("A healthy result."));
        }
        
        return Task.FromResult(
            new HealthCheckResult(
                context.Registration.FailureStatus, "An unhealthy result."));
    }
}