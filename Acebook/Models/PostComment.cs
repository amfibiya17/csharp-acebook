using System.ComponentModel.DataAnnotations;
using System.Data;

namespace acebook.Models;

public class QA
{
  public IList<Comment> comment { get; set; }
  public Post post { get; set; }
}