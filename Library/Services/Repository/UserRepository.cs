using AutoMapper;
using Library.Data;
using Library.Services.IRepository;

namespace Library.Services.Repository
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UserRepository(AppDbContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }


        public ApplicationUser GetById(string id)
        {
            return _context.ApplicationUsers.Find(id);
        }
    }
}
