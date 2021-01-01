using Library.Services.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Library.ApiCalls
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{bookAction}/{bookId:int}")]
        public IActionResult BorrowBook(int bookId, string bookAction)
        {
            var book = _unitOfWork.BookRepository.GetById(bookId);

            if (book == null)
                return Ok(new { success = false, message = "failed to return the book" });

            var bookActionValue = bookAction.Equals("returnBook", StringComparison.CurrentCultureIgnoreCase);
            book.IsAvailable = bookActionValue;

            var returnMessage = bookActionValue ? "returned" : "borrowed";

            _unitOfWork.SaveChanges();

            return Ok(new { success = true, message = $"successfully {returnMessage} the book {book.Title}" });
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
    }
}
