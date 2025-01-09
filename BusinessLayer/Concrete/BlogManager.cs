using BusinessLayer.Abstact;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)//Constructor metot ile bağımlılığı en aza indiriyoruz.Bu sayede test edilmesi daha kolay olur.blogDal nesnesi üzerinden veritabanı işlemlerini gerçekleştiririz.Constructor metot bize bir tane blogDal nesnesi vermek zorunda.
        {
            _blogDal = blogDal;
        }

        public void BlogAdd(Blog blog)
        {
           _blogDal.Insert(blog);//_blogDal nesnesi üzerinden Insert metotunu çağırıyoruz.
        }

        public void BlogDelete(Blog blog)
        {
            _blogDal.Delete(blog);//_blogDal nesnesi üzerinden Delete metotunu çağırıyoruz.
        }

        public void BlogUpdate(Blog blog)
        {
            _blogDal.Update(blog);//_blogDal nesnesi üzerinden Update metotunu çağırıyoruz.
        }

        public List<Blog> GetBlogID(int id)
        {
             return _blogDal.GetListAll(x => x.BlogID == id);//_blogDal nesnesi üzerinden GetListAll metotunu çağırıyoruz.
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetByID(id);//_blogDal nesnesi üzerinden GetByID metotunu çağırıyoruz.
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();//_blogDal nesnesi üzerinden GetListAll metotunu çağırıyoruz.
        }

        public List<Blog> GetBlogListWithCategory()
        {
           return _blogDal.GetlistWithCategory();//_blogDal nesnesi üzerinden GetlistWithCategory metotunu çağırıyoruz.
        }
    }
}
