using Microsoft.AspNetCore.Mvc;
using Onion.Domain.Entities;
using Onion.Application.Interfaces;

namespace Hexagonal.API.Controllers;
public class UserController : Controller
{
    private readonly IUserServices _userService;

    public UserController(IUserServices userService)
    {
        _userService = userService;
    }

    public IActionResult Insert(User model)
    {
        _userService.Insert(model);
        return View();

    }
}
