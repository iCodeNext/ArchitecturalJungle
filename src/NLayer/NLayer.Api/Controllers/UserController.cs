using Microsoft.AspNetCore.Mvc;
using NLayer.Application.Services;
using NLayer.Domain;
using NLayer.Services;

namespace NLayer.Controllers;
public class UserController(UserService userService,NotificationService notificationService) : Controller
{
    private readonly UserService _userService = userService;
    private readonly NotificationService _notificationService = notificationService;

    public IActionResult Insert(User model)
    {
        _userService.Insert(model);
        _notificationService.Send("Welcome to my website :)");
        return View();
    }
}
