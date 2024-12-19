using BusinessLayer.Abstact;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;

        public CategoryManager()//burdaki contructor ile EfCategoryRepository sınıfını newlemiş olduk.Constructor metotlar sınıf ismi ile aynı isimde olmalıdır.contructor metotlar sınıfı newlediğimizde çalışan metotlardır.Constructor metotların amacı sınıfı newlediğimizde çalışacak kodları içermektir.
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Insert(category);//EfCategoryRepository sınıfındaki Insert metotunu çağırdık ve parametre olarak category nesnesini verdik.
        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepository.Delete(category);//EfCategoryRepository sınıfındaki Delete metotunu çağırdık ve parametre olarak category nesnesini verdik.
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);//EfCategoryRepository sınıfındaki Update metotunu çağırdık ve parametre olarak category nesnesini verdik.
        }

        public Category GetById(int id)
        {
           return efCategoryRepository.GetByID(id);//EfCategoryRepository sınıfındaki GetByID metotunu çağırdık ve parametre olarak id değerini verdik.
        }

        public List<Category> GetList()
        {
            return efCategoryRepository.GetListAll();//EfCategoryRepository sınıfındaki GetListAll metotunu çağırdık.Return ile yazmamaızın sebebi bu metotun geriye değer döndürmesi.
        }
    }
}
