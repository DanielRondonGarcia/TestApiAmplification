using System.ComponentModel.DataAnnotations;

namespace TestApi.APIs;

public class UserViewOutput
{
    [Required()]
    public string FirstName { get; set; }

    [Required()]
    public string LastName { get; set; }

    [Required()]
    public string Email { get; set; }

    [Required()]
    public string Username { get; set; }
}
