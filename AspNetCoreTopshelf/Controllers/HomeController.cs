using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTopshelf.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}