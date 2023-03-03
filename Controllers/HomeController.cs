using Microsoft.AspNetCore.Mvc;

namespace Laway_SportStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
