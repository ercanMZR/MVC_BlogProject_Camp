using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MVC_ProjectCamp.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var values = abm.GetList();//AboutManager sınıfından türetilen abm nesnesi üzerinden GetList metotunu çağırır.
            return View(values);
        }

        public PartialViewResult SocialMediaAbout()
        {
           
            return PartialView();
        }
    }

    
}
