using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert (T t);

        void Delete(T t);

        void Update(T t);

        List<T> GetListAll();// Dışarıdan parametre almayan tüm listeleri getirir.

        T GetByID(int id);//ID'ye göre getir.

        List<T> GetListAll(Expression<Func<T, bool>> filter);//Filtreleme yapar.

    }
}
