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
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog blog)
        {
            using var c = new Context();//using içerisinde tanımlanan nesneler işi bitince hafızadan atılır.
            c.Add(blog);//add metodu ile blog nesnesini ekle.
            c.SaveChanges();

        }

        public void DeleteBlog(Blog blog)
        {
            using var c = new Context();
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetByID(int id)
        {
           using var c = new Context();
            return c.Blogs.Find(id);//ID'ye göre Blog getir.
        }

        public List<Blog> ListAllBlog()
        {
           using var c = new Context();
            return c.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            using var c = new Context();
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
