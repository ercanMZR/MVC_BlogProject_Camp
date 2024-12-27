using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MVC_ProjectCamp.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
           var values = bm.GetBlogListWithCategory;//BlogManager sınıfından türetilen bm nesnesi üzerinden GetBlogListWithCategory metotunu çağırır.
            return View(values());//View'e gönderir.
        }
    }
}
