using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog);//Blog nesnesi alır ve ekler.
        void BlogDelete(Blog blog);//Blog nesnesi alır ve siler.
        void BlogUpdate(Blog blog);//Blog nesnesi alır ve günceller.
        List<Blog> GetList();//Tüm blogları getirir.
        Blog GetById(int id);//ID'ye göre blog getirir.

        List<Blog> GetBlogListWithCategory();//Kategori ile birlikte blogları getirir.

        List<Blog> GetBlogListByWriter(int id);//Yazar ID'sine göre blogları getirir.


    }
}
