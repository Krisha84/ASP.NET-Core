using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Email()
        {
            return View();
        }

        public IActionResult SocialMedia()
        {
            return View();
        }
    }
}
