using Microsoft.EntityFrameworkCore;

namespace HealthChecksExample.Infrastructure;

public class TestDbContext : DbContext
{
    public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
    {
        //
    }
}