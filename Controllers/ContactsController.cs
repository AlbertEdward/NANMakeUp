using Microsoft.AspNetCore.Mvc;

namespace NANMakeup.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
