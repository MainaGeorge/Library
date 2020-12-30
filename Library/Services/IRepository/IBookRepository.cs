using System.Collections.Generic;
using Library.Entities;

namespace Library.Services.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetBooksByAuthor(int authorId);

        IEnumerable<Book> GetBooksWithAuthors();

    }
}
