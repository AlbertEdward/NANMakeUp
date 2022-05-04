using Microsoft.AspNetCore.Mvc;

namespace NANMakeup.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
