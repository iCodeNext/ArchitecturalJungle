using Hexagonal.Application.Domain;
using Hexagonal.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hexagonal.API.Controllers;
public class UserController : Controller
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    public IActionResult Insert(User model)
    {
        _userService.Insert(model);
        return View();
    }
}
