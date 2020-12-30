using System.Collections.Generic;
using System.Linq;
using Library.Data;
using Library.Entities;
using Library.Services.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Library.Services.Repository
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        private readonly AppDbContext _context;

        public AuthorRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Author> GetAuthorWithBooks()
        {
            return _context.Authors.Include(a => a.Books).ToList();
        }
    }
}
