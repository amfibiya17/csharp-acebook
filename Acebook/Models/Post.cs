using System.ComponentModel.DataAnnotations;
using System.Data;

namespace acebook.Models;

public class Post
{
  [Key]
  public int Id {get; set;}
  public DateTime TimePosted { get; set; } = DateTime.UtcNow;
  public string? Title {get; set;}
  public string? Content {get; set;}
  public int UserId {get; set;}
  public User? User {get; set;}
  public virtual ICollection<Comment>? Comments { get; set; }
}