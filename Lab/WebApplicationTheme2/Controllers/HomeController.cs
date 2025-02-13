using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTheme2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
