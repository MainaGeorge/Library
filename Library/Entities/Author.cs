using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    public class Author
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Maximum {2} characters exceeded")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Maximum {2} characters exceeded")]
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();

    }
}