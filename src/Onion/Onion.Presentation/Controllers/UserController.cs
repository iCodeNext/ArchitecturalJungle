using Microsoft.AspNetCore.Mvc;
using Onion.ApplicationService;
using Onion.Domain.Entities;

namespace Hexagonal.API.Controllers;
public class UserController(OrderManagement orderManagement) : Controller
{
    private readonly IOrderManagement _orderManagement = orderManagement;

    public IActionResult Insert(User model)
    {
        _orderManagement.AddOrder(5,"");

        return View();
    }
}
