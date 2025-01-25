using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MVC_ProjectCamp.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());// Dependency Injection.Bu şekilde bir bağımlılık oluşturduk.EfCommentRepository sınıfından bir nesne oluşturduk ve bu nesneyi CommentManager sınıfının constructor metotuna parametre olarak verdik.Bu parametre sayesinde CommentManager sınıfı EfCommentRepository sınıfındaki metotları kullanabilecek.
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {

           p.CommentDate = System.DateTime.Parse(System.DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogId = 1;
            cm.CommentAdd(p);
            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }
    }
}
