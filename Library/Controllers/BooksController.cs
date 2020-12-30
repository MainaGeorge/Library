using Library.Services.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        private readonly IUnitOfWork _iUnitOfWork;

        public BooksController(IUnitOfWork iUnitOfWork)
        {
            _iUnitOfWork = iUnitOfWork;
        }
        public IActionResult Index()
        {
            var books = _iUnitOfWork.BookRepository.GetBooksWithAuthors();
            return View(books);
        }
    }
}
