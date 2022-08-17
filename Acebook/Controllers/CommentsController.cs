using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using acebook.Models;
using acebook.ActionFilters;

namespace acebook.Controllers;

[ServiceFilter(typeof(AuthenticationFilter))]
public class CommentsController : Controller
{
  private readonly ILogger<CommentsController> _logger;

  public CommentsController(ILogger<CommentsController> logger)
  {
    _logger = logger;
  }

  [Route("/posts/comments")]
  [HttpGet]
  public IActionResult Index()
  {
    AcebookDbContext dbContext = new AcebookDbContext();
    List<Comment> comments = dbContext.Comments.ToList();
    ViewBag.Comments = comments;
    return View();
  }

  [Route("/posts/comments")]
  [HttpPost]
  public RedirectResult Create(Comment comment)
  {
    AcebookDbContext dbContext = new AcebookDbContext();
    int currentPostId = HttpContext.Session.GetInt32("post_id").Value;
    comment.PostId = currentPostId;
    dbContext.Comments.Add(comment);
    dbContext.SaveChanges();
    return new RedirectResult("/posts/comments");
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
