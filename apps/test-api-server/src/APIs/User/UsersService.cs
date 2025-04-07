using TestApi.Infrastructure;

namespace TestApi.APIs;

public class UsersService : UsersServiceBase
{
    public UsersService(TestApiDbContext context)
        : base(context) { }
}
