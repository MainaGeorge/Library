using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Library.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IEnumerable<Book> Books { get; set; } = new List<Book>();

        public DateTime DateOfBirth { get; set; }
    }
}
