using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>//IGenericDal'dan miras alındı.
    {
        List<Blog> ListAllBlog();//ListAllBlog metodu oluşturuldu.Blog listesi döndürecek.
        void AddBlog(Blog blog);//Blog ekleme metodu oluşturuldu.blog parametresi alacak.
        void DeleteBlog(Blog blog);//Blog silme metodu oluşturuldu.blog parametresi alacak.
        void UpdateBlog(Blog blog);//Blog güncelleme metodu oluşturuldu.blog parametresi alacak.
        Blog GetByID(int id);//ID'ye göre Blog getirme metodu oluşturuldu.id parametresi alacak.
    }
    //Fakat bu yapı DRY kavramına uymaz. Çünkü her bir entity için ayrı ayrı CRUD işlemleri yapılması gerekmektedir.
}
