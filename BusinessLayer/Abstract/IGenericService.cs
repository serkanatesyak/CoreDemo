using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T t);
        void Delete(T t);
        void TUpdate(T t);

        List<T> GetList();
        T TGetById(int id);

    }
}
