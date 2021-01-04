using System.Collections.Generic;
using Library.Entities;

namespace Library.Services.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> BorrowableBooks();
        IEnumerable<Book> GetBooksByAuthor(int authorId);

        IEnumerable<Book> GetBooksWithAuthors();

        IEnumerable<Book> GetBorrowedBooks();

        IEnumerable<Book> BooksByMe(string userId);

    }
}
