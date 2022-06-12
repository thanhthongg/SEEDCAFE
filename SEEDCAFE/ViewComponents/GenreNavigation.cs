using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEEDCAFE.Models;
namespace SEEDCAFE.ViewComponents
{
    public class GenreNavigation : ViewComponent
    {
        private ICafeRepository repository;
        public GenreNavigation(ICafeRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData?.Values["genre"];
            return View(repository.Books
            .Select(x => x.GioiThieu)
            .Distinct()
            .OrderBy(x => x));
        }

    }
}
