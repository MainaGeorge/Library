using System.Collections.Generic;
using Library.Entities;

namespace Library.Services.IRepository
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable<Author> GetAuthorWithBooks();
    }
}
