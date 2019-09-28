using System.Collections.Generic;

namespace BLL.Interfaces
{
    interface IService<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Put(T item);
        void Post(T item);
        void Delete(int id);
    }
}
