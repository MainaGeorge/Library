using Library.Services.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Authorize]
    public class BooksController : Controller
    {
        private readonly IUnitOfWork _iUnitOfWork;

        public BooksController(IUnitOfWork iUnitOfWork)
        {
            _iUnitOfWork = iUnitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_iUnitOfWork.BookRepository.GetBooksWithAuthors());
        }

        [HttpGet("{bookId:int}")]

        public IActionResult ReturnBook(int bookId)
        {
            var book = _iUnitOfWork.BookRepository.GetById(bookId);

            if (book == null)
                return Ok(new { message = $"could not find such a book", success = false });

            book.IsAvailable = true;
            _iUnitOfWork.SaveChanges();

            return Ok(new { message = $"successfully returned book {book.Title}", success = true });
        }
        [HttpGet("{bookId:int}")]
        public IActionResult BorrowBook(int bookId)
        {
            var book = _iUnitOfWork.BookRepository.GetById(bookId);

            if (book == null)
                return Ok(new { success = false, message = "can not find the book" });

            book.IsAvailable = false;

            _iUnitOfWork.SaveChanges();

            return Ok(new { success = true, message = $"successfully borrowed the book {book.Title}" });
        }



    }
}
