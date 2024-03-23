using Microsoft.AspNetCore.Mvc;
using NoArchitecture.Domain;
using NoArchitecture.Services;

namespace NoArchitecture.Controllers;
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
