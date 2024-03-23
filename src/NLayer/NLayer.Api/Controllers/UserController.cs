using Microsoft.AspNetCore.Mvc;
using NLayer.Domain;
using NLayer.Services;

namespace NLayer.Controllers;
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
