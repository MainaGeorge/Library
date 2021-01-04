using Library.Data;
using Library.Entities;
using Library.Services.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Library.Services.Repository
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }


        public ApplicationUser GetById(string id)
        {
            return _context
                .ApplicationUsers
                .Where(u => u.Id == id)
                .Include(b => b.Books)
                .FirstOrDefault();

        }
    }
}
