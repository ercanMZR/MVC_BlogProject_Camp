using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal//ICategoryDal interface'ini implemente ediyoruz.
    {
        Context c = new Context();//Context sınıfından bir nesne ürettik.
        public void AddCategory(Category category)
        {
            c.Add(category);//Gelen category'i ekle.
            c.SaveChanges();//Değişiklikleri kaydet.
        }

        public void DeleteCategory(Category category)
        {
            c.Remove(category);//Gelen category'i sil.
            c.SaveChanges();//Değişiklikleri kaydet.
        }

        public Category GetByID(int id)
        {
            return c.Categories.Find(id);//ID'ye göre Category getir.
        }

        public List<Category> ListAllCategory()
        {
            return c.Categories.ToList();//Tüm categorileri listele.
        }

        public void UpdateCategory(Category category)
        {
           c.Update(category);//Gelen category'i güncelle.
            c.SaveChanges();
        }
    }
}
