using Microsoft.AspNetCore.Mvc;
using Onion.Domain.Entities;
using Onion.Domain.Interfaces;

namespace Hexagonal.API.Controllers;
public class UserController(IUserServices userService) : Controller
{
    private readonly IUserServices _userService = userService;

    public IActionResult Insert(User model)
    {
        _userService.Insert(model);
        return View();

    }
}
