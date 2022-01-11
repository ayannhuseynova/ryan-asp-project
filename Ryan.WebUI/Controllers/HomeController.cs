using Microsoft.AspNetCore.Mvc;

namespace Ryan.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
