using Microsoft.AspNetCore.Mvc;

namespace TestApi.APIs;

[ApiController()]
public class UsersController : UsersControllerBase
{
    public UsersController(IUsersService service)
        : base(service) { }
}
