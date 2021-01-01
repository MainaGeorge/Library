using Library.Data;
using Library.Services.IRepository;

namespace Library.Services.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            BookRepository = new BookRepository(context);
            AuthorRepository = new AuthorRepository(context);
            UserRepository = new UserRepository(context);
        }
        public IBookRepository BookRepository { get; }
        public IAuthorRepository AuthorRepository { get; }
        public IUserRepository UserRepository { get; }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
