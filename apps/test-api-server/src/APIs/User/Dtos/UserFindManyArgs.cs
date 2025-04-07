using Microsoft.AspNetCore.Mvc;
using TestApi.APIs.Common;
using TestApi.Infrastructure.Models;

namespace TestApi.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class UserFindManyArgs : FindManyInput<User, UserWhereInput> { }
