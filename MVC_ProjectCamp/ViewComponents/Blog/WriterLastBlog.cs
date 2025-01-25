using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace MVC_ProjectCamp.ViewComponents.Blog
{
    public class WriterLastBlog:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()//Invoke metodu çağrıldığında çalışacak
        {
           var values=bm.GetBlogListByWriter(1);//BlogManager sınıfından türetilen bm nesnesi üzerinden GetBlogListByWriter metotunu çağırır.
            return View(values);//View'e gönderir.
        }
    }
}
