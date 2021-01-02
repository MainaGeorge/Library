using System.Collections.Generic;
using Library.Entities;
using Library.Utility;

namespace Library.Models
{
    public class AuthorViewModel
    {
        public PaginationDetails PageModel { get; set; }
        public IEnumerable<Author> Authors { get; set; }        
    }
}
