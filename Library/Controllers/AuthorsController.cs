using Library.Services.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IUnitOfWork _iUnitOfWork;

        public AuthorsController(IUnitOfWork iUnitOfWork)
        {
            _iUnitOfWork = iUnitOfWork;
        }
        public IActionResult Index()
        {
            var model = _iUnitOfWork.AuthorRepository.GetAuthorWithBooks();
            return View(model);
        }
    }
}
