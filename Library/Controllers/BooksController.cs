using Library.Entities;
using Library.Services.IRepository;
using Library.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Library.Controllers
{
    [Authorize(Roles = "regular")]
    public class BooksController : Controller
    {
        private readonly IUnitOfWork _iUnitOfWork;
        private readonly IHttpContextAccessor _contextAccessor;

        public BooksController(IUnitOfWork iUnitOfWork,
            IHttpContextAccessor contextAccessor)
        {
            _iUnitOfWork = iUnitOfWork;
            _contextAccessor = contextAccessor;
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

        public IActionResult BorrowBooks()
        {
            var books =
                _contextAccessor.HttpContext.Session.RetrieveFromSession<List<int>>(AppConstants.ShoppingCart);

            var loggedUserId = _contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedUser = _iUnitOfWork.UserRepository.GetById(loggedUserId);

            if (loggedUser == null)
                return View("Error");

            var booksBorrowed = new List<Book>();

            if (books != null && books.Any())
            {

                foreach (var newBook in books.Select(bookId => _iUnitOfWork.BookRepository.GetById(bookId)))
                    newBook.BorrowerId = loggedUserId;

                loggedUser.Books = booksBorrowed;
                _contextAccessor.HttpContext.Session.SetString(AppConstants.ShoppingCart, "");
                _iUnitOfWork.SaveChanges();

            }

            var userWithBorrowedBooks = _iUnitOfWork.UserRepository.GetById(loggedUserId);

            return View(userWithBorrowedBooks.Books);


        }

    }
}
