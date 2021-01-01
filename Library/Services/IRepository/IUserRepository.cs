using Library.Data;

namespace Library.Services.IRepository
{
    public interface IUserRepository  : IRepository<ApplicationUser>
    {
        public ApplicationUser GetById(string id);
    }
}
