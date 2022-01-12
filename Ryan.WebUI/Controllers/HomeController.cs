using Microsoft.AspNetCore.Mvc;
using Ryan.WebUI.Models.DataContexts;
using Ryan.WebUI.Models.Entities;

namespace Ryan.WebUI.Controllers
{
    public class HomeController : Controller
    {
        readonly RyanDbContext db;
        public HomeController(RyanDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Resume()
        {
            return View();
        }
        public IActionResult Works()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();

                ModelState.Clear();

                ViewBag.Message = "Your message was sent successfully. Hold on tight, our team will answer you soon! :)";
                return View();
            }
            
            return View(contact);
        }
    }
}
