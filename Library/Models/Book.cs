using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Book
    {
        [Required]
        [Key]
        public int Id { get; set; }


        [Required]
        public string Title { get; set; }

        [ForeignKey("Author")]
        public string AuthorId { get; set; }

        public Author Author { get; set; }   

    }

    public class Author
    {
        [Required]
        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Maximum {2} characters exceeded")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Maximum {2} characters exceeded")]
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
