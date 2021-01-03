using System.Collections.Generic;
using Library.Utility;

namespace Library.Models
{
    public class UserWithRolesViewModel
    {
        public IEnumerable<UserWithRolesModel> Users { get; set; }

        public PaginationDetails PageModel { get; set; }


    }
}
