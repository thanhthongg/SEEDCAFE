using Microsoft.AspNetCore.Mvc;
using SEEDCAFE.Models;
using SEEDCAFE.Models.ViewModels;
using System.Linq;

namespace SEEDCAFE.Controllers
{
    public class HomeController : Controller
    {
        private ICafeRepository repository;
        public int PageSize = 3;
        public HomeController(ICafeRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index(string genre, int bookPage = 1)
  => View(new BooksListViewModel
  {
      Books = repository.Books
  .Where(p => genre == null || p.GioiThieu == genre)
  .OrderBy(p => p.BookID)
  .Skip((bookPage - 1) * PageSize)
  .Take(PageSize),
      PagingInfo = new PagingInfo
      {
          CurrentPage = bookPage,
          ItemsPerPage = PageSize,
          TotalItems = repository.Books.Count()
      },
      CurrentGenre = genre
  });

    }
}