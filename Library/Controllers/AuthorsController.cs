using cloudscribe.Pagination.Models;
using Library.Entities;
using Library.Services.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Library.Controllers
{
    [Authorize]
    public class AuthorsController : Controller
    {
        private readonly IUnitOfWork _iUnitOfWork;

        public AuthorsController(IUnitOfWork iUnitOfWork)
        {
            _iUnitOfWork = iUnitOfWork;
        }
        public IActionResult Index(int pageNumber = 1, int pageSize = 4)
        {

            var skipItems = (pageNumber * pageSize) - pageSize;
            var books = _iUnitOfWork.AuthorRepository.GetAuthorWithBooks().ToList();
            var query = books.Skip(skipItems).Take(pageSize);
            var result = new PagedResult<Author>()
            {
                Data = query.ToList(),
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalItems = books.Count()

            };
            return View(result);
        }
        [HttpGet]
        public IActionResult GetAuthors()
        {
            return Ok(_iUnitOfWork.AuthorRepository.GetAuthorWithBooks());
        }
    }
}
