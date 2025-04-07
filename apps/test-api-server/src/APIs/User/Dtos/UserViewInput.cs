using System.ComponentModel.DataAnnotations;

namespace TestApi.APIs;

public class UserViewInput
{
    [Required()]
    public string UserId { get; set; }
}
