using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Library.Data;

namespace Library.Entities
{
    public class Book
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        public string Title { get; set; }

        [Required]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public Author Author { get; set; }

        [ForeignKey("Borrower")]
        public string BorrowerId { get; set; }

        public AppUsers Borrower { get; set; }

        public bool IsAvailable { get; set; } = true;

    }
}
