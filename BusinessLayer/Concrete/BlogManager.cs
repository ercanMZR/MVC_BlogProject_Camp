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
            throw new NotImplementedException();
        }

        public void BlogDelete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogUpdate(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
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
