using Library.Services.IRepository;
using Library.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Library.Controllers
{
    [Authorize]
    public class BooksController : Controller
    {
        private readonly IUnitOfWork _iUnitOfWork;
        private readonly IWebHostEnvironment _host;

        public BooksController(IUnitOfWork iUnitOfWork, IWebHostEnvironment host)
        {
            _iUnitOfWork = iUnitOfWork;
            _host = host;
        }

        [HttpGet]
        public IActionResult CustomPaged(int pageNumber = 1, int pageSize = 8)
        {
            var books = _iUnitOfWork.BookRepository.GetBooksWithAuthors().ToList();
            var result = PaginateResult.PageResults(books, pageNumber, pageSize);

            return View(result);

        }

        public IActionResult Index()
        {
            return View();
        }



    }
}
