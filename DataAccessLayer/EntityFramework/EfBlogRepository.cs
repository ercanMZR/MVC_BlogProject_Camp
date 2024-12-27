using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
     

        public List<Blog> GetlistWithCategory()
        {
          using(var c= new Context())//Context sınıfından bir nesne oluşturuldu.usign bloğu içerisinde kullanıldığı için bellekten silinir.usign burada şu işe yarar:using bloğu içerisinde tanımlanan nesne işi bitince bellekten silinir.
            {
                return c.Blogs.Include(x=> x.Category).ToList();//include metodu ile ilişkili tabloyu getirir.
            }
        }

    }
}
