using Microsoft.AspNetCore.Mvc;
using NoArchitecture.Services;

namespace NoArchitecture.Controllers;
public class UserController(ApplicationDbContext dbContext) : Controller
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public IActionResult Insert(User model)
    {
        if (model.Name.StartsWith("M"))
        {
            return View("Error");
        }
        _dbContext.Users.Add(model);
        _dbContext.SaveChanges();
        return View();
    }
}
