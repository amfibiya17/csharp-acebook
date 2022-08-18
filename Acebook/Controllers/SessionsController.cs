using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using acebook.Models;

namespace acebook.Controllers;

public class SessionsController : Controller
{
  private readonly ILogger<SessionsController> _logger;

  public SessionsController(ILogger<SessionsController> logger)
  {
    _logger = logger;
  }

  [Route("/signin")]
  [HttpGet]
  public IActionResult New()
  {
    AcebookDbContext dbContext = new AcebookDbContext();
    int currentUserId = HttpContext.Session.GetInt32("user_id").GetValueOrDefault(-1);
    ViewBag.UserId = currentUserId;
    bool isSignedIn = currentUserId != -1;
    Console.WriteLine(isSignedIn);
    ViewBag.IsSignedIn = isSignedIn;
    return View();
  }

  [Route("/signin")]
  [HttpPost]
  public RedirectResult Create(string email, string password)
  {
    AcebookDbContext dbContext = new AcebookDbContext();
    User? user = dbContext.Users.Where(user => user.Email == email).First();
    if (user != null && user.Password == password)
    {
      HttpContext.Session.SetInt32("user_id", user.Id);
      return new RedirectResult("/posts");
    }
    else
    {
      return new RedirectResult("/signin");
    }
  }

  [Route("/signout")]
  [HttpPost]
  [HttpGet]
  public ActionResult SignOut()
  {
    Console.WriteLine("Logging out...");
    HttpContext.Session.Clear();
    return new RedirectResult("/");
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
