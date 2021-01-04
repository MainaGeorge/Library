using Library.Data;
using Library.Entities;
using Library.Services.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Library.Services.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Book> BorrowableBooks()
        {
            return _context.Books.Where(b => b.IsAvailable).Include(b => b.Author);
        }

        public IEnumerable<Book> GetBooksByAuthor(int authorId)
        {
            return _context.Books.Where(b => b.AuthorId == authorId).ToList();
        }

        public IEnumerable<Book> GetBooksWithAuthors()
        {
            return _context.Books
                .Include(b => b.Author)
                .OrderBy(b => b.IsAvailable)
                .ToList();
        }

        public IEnumerable<Book> GetBorrowedBooks()
        {
            return _context
                .Books
                .Include(b => b.Borrower)
                .Where(b => !string.IsNullOrWhiteSpace(b.BorrowerId)).ToList();
        }

        public IEnumerable<Book> BooksByMe(string userId)
        {
            return _context
                .Books
                .Where(b => !string.IsNullOrWhiteSpace(b.BorrowerId) && b.BorrowerId == userId)
                .Include(b => b.Author);
        }
    }
}
