using Microsoft.AspNetCore.Mvc;
using NoArchitecture.Context;
using NoArchitecture.Domain;
using NoArchitecture.Services;

namespace NoArchitecture.Controllers;
public class UserController(ApplicationDbContext dbContext) : Controller
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public IActionResult Insert(User model)
    {
        // dfasdfd
        _dbContext.Users.Add(model);
        _dbContext.SaveChanges();
        return View();
    }
}
