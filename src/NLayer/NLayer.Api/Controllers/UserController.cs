using Microsoft.AspNetCore.Mvc;
using NLayer.Domain;
using NLayer.Services;

namespace NLayer.Controllers;
public class UserController(UserService userService) : Controller
{
    private readonly UserService _userService = userService;

    public IActionResult Insert(User model)
    {
        _userService.Insert(model);
        return View();
    }
}
