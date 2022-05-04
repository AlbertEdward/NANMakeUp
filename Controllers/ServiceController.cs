using Microsoft.AspNetCore.Mvc;

namespace NANMakeup.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
