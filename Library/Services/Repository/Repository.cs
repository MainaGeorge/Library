using Library.Data;
using Library.Services.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace Library.Services.Repository
{
    public class Repository<T> : IRepository<T> where T : class

    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            _context.Remove(entity);
        }
    }
}
