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
    public class CommentManager : ICommentService//ICommentService arayüzünden implement edilir.
    {
        ICommentDal _commentdal;//ICommentDal türünden _commentdal adında bir nesne tanımlanır.

        public CommentManager(ICommentDal commentdal)//Constructor metot oluşturulur ve parametre olarak ICommentDal türünden commentdal alır.
        {
            _commentdal = commentdal;//Yerel _commentdal nesnesine parametre olarak gelen commentdal atanır.
        }

        public void CommentAdd(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList(int id)
        {
           return _commentdal.GetListAll(x=>x.BlogId==id );//_commentdal nesnesi üzerinden GetListAll metotu çağrılır ve geriye dönen değer döndürülür.
        }

      
    }
}
