using Microsoft.EntityFrameworkCore;

namespace TestApi.Infrastructure;

public class TestApiDbContext : DbContext
{
    public TestApiDbContext(DbContextOptions<TestApiDbContext> options)
        : base(options) { }
}
