using Microsoft.AspNetCore.Mvc;

namespace MVC_ProjectCamp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
