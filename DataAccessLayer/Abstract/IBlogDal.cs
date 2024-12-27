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

        List<Blog> GetlistWithCategory();
      
    }
    //Fakat bu yapı DRY kavramına uymaz. Çünkü her bir entity için ayrı ayrı CRUD işlemleri yapılması gerekmektedir.
}
