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
                return Ok(new { success = false, message = "wrong" });

            book.IsAvailable = bookAction.Equals("returnBook", StringComparison.CurrentCultureIgnoreCase);

            _unitOfWork.SaveChanges();

            return Ok(new { success = true, message = "success" });
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unitOfWork.BookRepository.GetBooksWithAuthors());
        }
    }
}
