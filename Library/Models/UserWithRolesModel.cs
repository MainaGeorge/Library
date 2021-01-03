using Library.Entities;

namespace Library.Models
{
    public class UserWithRolesModel
    {
        public ApplicationUser ApplicationUser { get; set; }

        public string Roles { get; set; }

    }
}
