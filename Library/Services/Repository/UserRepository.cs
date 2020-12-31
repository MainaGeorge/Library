using Library.Data;
using Library.Services.IRepository;

namespace Library.Services.Repository
{
    public class UserRepository : Repository<AppUsers>, IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public AppUsers GetById(string id)
        {
            return _context.Users.Find(id);
        }
    }
}
