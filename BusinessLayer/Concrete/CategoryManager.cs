using BusinessLayer.Abstact;
using DataAccessLayer.Abstract;
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
        ICategoryDal _categoryDal;//ICategoryDal türünde _categoryDal isminde bir field tanımladık.

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;//Constructor metot ile _categoryDal field'ına parametre olarak gelen categoryDal nesnesini atadık.
        }
        public void CategoryAdd(Category category)
        {
           _categoryDal.Insert(category);//EfCategoryRepository sınıfındaki Insert metotunu çağırdık ve parametre olarak category nesnesini verdik._categoryDal field'ı ICategoryDal türünde olduğu için burada EfCategoryRepository sınıfındaki metotları kullanabiliyoruz.
        }

        public void CategoryDelete(Category category)
        {
           _categoryDal.Delete(category);//EfCategoryRepository sınıfındaki Delete metotunu çağırdık ve parametre olarak category nesnesini verdik.
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);//EfCategoryRepository sınıfındaki Update metotunu çağırdık ve parametre olarak category nesnesini verdik.
        }

        public Category GetById(int id)
        {
           return _categoryDal.GetByID(id);//EfCategoryRepository sınıfındaki GetByID metotunu çağırdık ve parametre olarak id değerini verdik.
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();//EfCategoryRepository sınıfındaki GetListAll metotunu çağırdık.Return ile yazmamaızın sebebi bu metotun geriye değer döndürmesi.
        }
    }
}
