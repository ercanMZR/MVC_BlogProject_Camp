using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MVC_ProjectCamp.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContactTime = DateTime.Parse(DateTime.Now.ToShortDateString());//güncel tarihi alır
            p.ContactStatus = true;//mesajın durumu
            cm.ContactAdd(p);//mesajı ekle
            return RedirectToAction("Index", "Blog");//blog sayfasına yönlendir
        }
    }
}
