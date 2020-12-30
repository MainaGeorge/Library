using cloudscribe.Pagination.Models;
using Library.Entities;
using Library.Services.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        private readonly IUnitOfWork _iUnitOfWork;

        public BooksController(IUnitOfWork iUnitOfWork)
        {
            _iUnitOfWork = iUnitOfWork;
        }
        public IActionResult Index(int pageSize = 8, int pageNumber = 1)
        {
            var skipItems = (pageNumber * pageSize) - pageSize;
            var books = _iUnitOfWork.BookRepository.GetBooksWithAuthors().ToList();
            var query = books.Skip(skipItems).Take(pageSize);
            var result = new PagedResult<Book>()
            {
                Data = query.ToList(),
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalItems = books.Count()

            };
            return View(result);
        }
    }
}
