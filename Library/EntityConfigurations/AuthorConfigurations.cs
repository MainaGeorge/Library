using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Library.EntityConfigurations
{
    public class AuthorConfigurations : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(Authors);
        }


        private static IEnumerable<Author> Authors => new List<Author>()
        {
            new Author() {FirstName = "James", LastName = "Bond", Id =1},
            new Author() {FirstName = "Jackie", LastName = "Chan", Id =2},
            new Author() {FirstName = "Sylvester", LastName = "Stallone", Id =3},
            new Author() {FirstName = "Van", LastName = "Damme", Id = 4},
            new Author() {FirstName = "Jet", LastName = "Lee", Id = 5}

        };
    }
}
