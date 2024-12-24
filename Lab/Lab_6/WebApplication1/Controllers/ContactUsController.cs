using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
