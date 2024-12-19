using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>//IGenericDal'dan miras alındı.
    {
        List<Category>ListAllCategory();//ListAllCategory metodu oluşturuldu.Categori listesi döndürecek.

        void AddCategory(Category category);//Category ekleme metodu oluşturuldu.category parametresi alacak.

        void DeleteCategory(Category category);//Category silme metodu oluşturuldu.category parametresi alacak.

        void UpdateCategory(Category category);//Category güncelleme metodu oluşturuldu.category parametresi alacak.

        Category GetByID(int id);//ID'ye göre Category getirme metodu oluşturuldu.id parametresi alacak.
    }
}
