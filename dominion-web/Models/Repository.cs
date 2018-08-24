using System.Collections.Generic;
using System.Linq;

namespace dominion_web.Models
{
  public class Repository
  {
    public string Name { get; set; }
    public IEnumerable<string> Files { get; set; }

    public bool IsCSharpProject
    {
      get
      {
        return Files.Any(x => x.EndsWith(".cs"));
      }
    }
  }
}