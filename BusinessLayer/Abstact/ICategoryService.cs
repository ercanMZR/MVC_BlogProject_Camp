using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface ICategoryService
    {
        void CategoryAdd(Category category);//Category nesnesi alır ve ekler.

        void CategoryDelete(Category category);//Category nesnesi alır ve siler.

        void CategoryUpdate(Category category);//Category nesnesi alır ve günceller.

        List<Category> GetList();//Tüm kategorileri getirir.

        Category GetById(int id);//ID'ye göre kategori getirir.
    }
}
