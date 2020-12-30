using Library.Data;
using Library.Entities;
using Library.Services.IRepository;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Library.Services.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetBooksByAuthor(int authorId)
        {
            return _context.Books.Where(b => b.AuthorId == authorId).ToList();
        }

        public IEnumerable<Book> GetBooksWithAuthors()
        {
            return _context.Books.Include(b => b.Author).ToList();
        }
    }
}
