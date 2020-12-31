using Library.Services.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Library.ApiCalls
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BorrowController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{bookId:int}")]
        public IActionResult BorrowBook(int bookId)
        {
            var book = _unitOfWork.BookRepository.GetById(bookId);

            if (book == null)
                return Ok(new { success = false, message = "wrong" });
            book.IsAvailable = false;
            _unitOfWork.SaveChanges();

            return Ok(new { success = true, message = "success" });
        }
    }
}
