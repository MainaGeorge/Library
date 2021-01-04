using Library.Services.IRepository;
using Library.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;

namespace Library.ApiCalls
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _contextAccessor;

        public BookController(IUnitOfWork unitOfWork, IHttpContextAccessor contextAccessor)
        {
            _unitOfWork = unitOfWork;
            _contextAccessor = contextAccessor;
        }

        [HttpGet("borrowBook/{bookId:int}")]
        public IActionResult BorrowBook(int bookId)
        {
            var book = _unitOfWork.BookRepository.GetById(bookId);

            if (book == null)
                return Ok(new { success = false, message = "can not find the book" });

            var booksToBorrow =
                _contextAccessor.HttpContext.Session
                    .RetrieveFromSession<List<int>>(AppConstants.ShoppingCart) ?? new List<int>();

            booksToBorrow.Add(bookId);

            _contextAccessor.HttpContext.Session.SaveObjectInSession(AppConstants.ShoppingCart, booksToBorrow);

            book.IsAvailable = false;

            _unitOfWork.SaveChanges();

            return Ok(new { success = true, message = $"successfully borrowed the book {book.Title}" });
        }

        [HttpGet("returnBook/{bookId:int}")]

        public IActionResult ReturnBook(int bookId)
        {
            var book = _unitOfWork.BookRepository.GetById(bookId);

            if (book == null)
                return Ok(new { message = $"could not find such a book", success = false });

            book.IsAvailable = true;
            book.BorrowerId = null;

            _unitOfWork.SaveChanges();

            return Ok(new { message = $"successfully returned book {book.Title}", success = true });
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unitOfWork.BookRepository.GetBooksWithAuthors());
        }

        [HttpDelete("users/{userId}")]
        public IActionResult Delete(string userId)
        {
            var user = _unitOfWork.UserRepository.GetById(userId);

            if (user == null) return Ok(new { message = "failed to delete user", sucess = false });

            _unitOfWork.UserRepository.Remove(user);

            _unitOfWork.SaveChanges();

            return Ok(new { Message = "user deleted successfully", success = true });
        }

        [HttpGet("BooksByMe")]
        public IActionResult BooksByMe()
        {
            var loggedUserId = _contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrWhiteSpace(loggedUserId))
                return Ok(null);

            var booksByMe = _unitOfWork.BookRepository.BooksByMe(loggedUserId);

            return Ok(booksByMe);
        }
    }
}
