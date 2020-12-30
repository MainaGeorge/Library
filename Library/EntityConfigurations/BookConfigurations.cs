using System.Collections.Generic;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.EntityConfigurations
{
    public class BookConfigurations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(Books);
        }

        private static IEnumerable<Book> Books => new List<Book>()
        {
            new Book(){Id = 1, AuthorId = 1, Title = "Spectre"},
            new Book(){Id = 2, AuthorId = 1, Title = "Casino Royal"},
            new Book(){Id = 3, AuthorId = 1, Title = "007"},
            new Book(){Id = 4, AuthorId = 1, Title = "The spy who loved me"},
            new Book(){Id = 5, AuthorId = 1, Title = "From russia with love"},
            new Book(){Id = 6, AuthorId = 1, Title = "Die another day"},
            new Book(){Id = 7, AuthorId = 2, Title = "Rush Hour"},
            new Book(){Id = 8, AuthorId = 2, Title = "Police story"},
            new Book(){Id = 9, AuthorId = 2, Title = "Who am I?"},
            new Book(){Id = 10, AuthorId = 2, Title = "The karate kid"},
            new Book(){Id = 11, AuthorId = 2, Title = "Drunken Master"},
            new Book(){Id = 12, AuthorId = 3, Title = "Rambo"},
            new Book(){Id = 13, AuthorId = 3, Title = "First Blood"},
            new Book(){Id = 14, AuthorId = 3, Title = "The expendables"},
            new Book(){Id = 15, AuthorId = 3, Title = "Escape plan"},
            new Book(){Id = 16, AuthorId = 3, Title = "Judgment Day"},
            new Book(){Id = 17, AuthorId = 4, Title = "Hard Target"},
            new Book(){Id = 18, AuthorId = 4, Title = "Double Impact"},
            new Book(){Id = 19, AuthorId = 4, Title = "Universal Soldier"},
            new Book(){Id = 20, AuthorId = 4, Title = "Hard Way"},
            new Book(){Id = 21, AuthorId = 4, Title = "Street Fighter"},
            new Book(){Id = 22, AuthorId = 4, Title = "Bullet in the head"},
            new Book(){Id = 23, AuthorId = 5, Title = "The Black Mask"},
            new Book(){Id = 24, AuthorId = 5, Title = "Romeo Must Die"},
            new Book(){Id = 25, AuthorId = 5, Title = "Cradle to the grave"},
            new Book(){Id = 26, AuthorId = 5, Title = "Once upon a time in China"},
            new Book(){Id = 27, AuthorId = 5, Title = "Hero"},
            new Book(){Id = 28, AuthorId = 5, Title = "Fearless"},
            new Book(){Id = 29, AuthorId = 5, Title = "Fist of legend"},
            new Book(){Id = 30, AuthorId = 5, Title = "The one"},
            new Book(){Id = 31, AuthorId = 5, Title = "Unleashed"},
        };
    }
}
