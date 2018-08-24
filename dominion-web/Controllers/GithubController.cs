using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dominion_web.Controllers
{
  public class GithubController : Controller
  {
    public async Task<IActionResult> Issues(string owner, string repoName)
    {
      ViewBag.owner = owner;
      ViewBag.repoName = repoName;
      
      return View();
    }
  }
}