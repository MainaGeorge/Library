using cloudscribe.Pagination.Models;
using Library.Entities;
using Library.Services.IRepository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        private readonly IUnitOfWork _iUnitOfWork;
        private readonly IWebHostEnvironment _host;

        public BooksController(IUnitOfWork iUnitOfWork, IWebHostEnvironment host)
        {
            _iUnitOfWork = iUnitOfWork;
            _host = host;
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


        public IActionResult Data()
        {
            var applicationPath = Path.GetDirectoryName(Assembly.GetEntryAssembly()?.FullName);
            // var data = System.IO.File.ReadAllLines(applicationPath + @"\Data\userData.json");

            return View("Data", applicationPath);
        }
    }
}
