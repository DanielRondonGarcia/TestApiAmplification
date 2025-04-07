using Microsoft.EntityFrameworkCore;
using TestApi.Infrastructure.Models;

namespace TestApi.Infrastructure;

public class TestApiDbContext : DbContext
{
    public TestApiDbContext(DbContextOptions<TestApiDbContext> options)
        : base(options) { }

    public DbSet<UserDbModel> Users { get; set; }
}
