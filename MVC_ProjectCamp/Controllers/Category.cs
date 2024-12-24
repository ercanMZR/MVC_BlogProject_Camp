using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MVC_ProjectCamp.Controllers
{
    public class Category : Controller
    {

        CategoryManager cm = new CategoryManager(new EfCategoryRepository());// Dependency Injection.Bu şekilde bir bağımlılık oluşturduk.EfCategoryRepository sınıfından bir nesne oluşturduk ve bu nesneyi CategoryManager sınıfının constructor metotuna parametre olarak verdik.Bu parametre sayesinde CategoryManager sınıfı EfCategoryRepository sınıfındaki metotları kullanabilecek.
        public IActionResult Index()
        {
            var values = cm.GetList();//CategoryManager sınıfındaki GetList metotunu çağırdık ve geriye dönen değeri values değişkenine atadık.
            return View(values);//values değişkenini view'e gönderdik.Bu sayede view tarafında values değişkenine erişebileceğiz.
        }
    }
}
