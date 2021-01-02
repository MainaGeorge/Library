using Library.Models;
using Library.Services.IRepository;
using Library.Utility;
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

        [HttpGet]
        public IActionResult Index(int pageNumber = 1)
        {
            var authors = _iUnitOfWork.AuthorRepository.GetAuthorWithBooks().ToList();
            var pagingInfo = new PaginationDetails()
            {
                TotalItems = authors.Count(),
                CurrentPage = pageNumber,
                ItemsPerPage = AppConstants.ItemsPerPage,
                Url = "/Authors/Index"
            };

            var itemsToSkip = (pageNumber * AppConstants.ItemsPerPage) - AppConstants.ItemsPerPage;
            var dataToDisplay = authors.Skip(itemsToSkip).Take(AppConstants.ItemsPerPage);

            var viewModel = new AuthorViewModel() { Authors = dataToDisplay, PageModel = pagingInfo };

            return View(viewModel);
        }


    }
}
