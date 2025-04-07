using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestApi.Infrastructure.Models;

namespace TestApi.Infrastructure;

public class TestApiDbContext : IdentityDbContext<IdentityUser>
{
    public TestApiDbContext(DbContextOptions<TestApiDbContext> options)
        : base(options) { }

    public DbSet<UserDbModel> Users { get; set; }
}
