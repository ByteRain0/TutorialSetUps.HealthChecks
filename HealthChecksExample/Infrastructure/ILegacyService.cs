namespace HealthChecksExample.Infrastructure;

public interface ILegacyService
{
    bool IsAlive();
}

public class LegacyService : ILegacyService
{
    public bool IsAlive()
    {
        var random = new Random();
        return random.Next(10) / 2 == 0;
    }
}