using Hexagonal.Application.Domain;
using Hexagonal.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hexagonal.API.Controllers;
public class UserController(UserService userService) : Controller
{
    private readonly UserService _userService = userService;

    public IActionResult Insert(User model)
    {
        _userService.Insert(model);
        return View();
    }
}
