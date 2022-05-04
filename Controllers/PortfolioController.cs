using Microsoft.AspNetCore.Mvc;

namespace NANMakeup.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
