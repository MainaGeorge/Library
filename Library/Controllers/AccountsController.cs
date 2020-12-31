using Library.Services.IRepository;
using Library.Utility;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Library.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index(int pageNumber = 1, int pageSize = 6)
        {
            var users = _unitOfWork.UserRepository.GetAll().ToList();

            var result = PaginateResult.PageResults(users, pageNumber, pageSize);

            return View(result);
        }
    }
}
