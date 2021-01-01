using Library.Data;
using Library.Services.IRepository;

namespace Library.Services.Repository
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }


    }
}
