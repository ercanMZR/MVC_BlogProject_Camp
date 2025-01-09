using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstact
{
    public interface  ICommentService
    {
        void CommentAdd(Comment comment);

        //void CategoryDelete(Comment comment);//Category nesnesi alır ve siler.

        //void CategoryUpdate(Comment comment);//Category nesnesi alır ve günceller.

        List<Comment> GetList(int id);

       // Comment GetById(int id);//ID'ye göre kategori getirir.
    }
}
