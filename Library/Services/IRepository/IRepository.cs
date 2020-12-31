using System.Collections.Generic;

namespace Library.Services.IRepository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        T GetById(int id);
        void Remove(T entity);
    }
}
