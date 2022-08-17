using System.ComponentModel.DataAnnotations;
using System.Data;

namespace acebook.Models;

public class Comment
{
  [Key]
  public int Id {get; set;}
  public DateTime TimeCommented { get; set; } = DateTime.UtcNow;
  public string? CommentContent {get; set;}
  public int UserId {get; set;}
  public User? User {get; set;}
  public int PostId {get; set;}
}
