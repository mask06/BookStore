using BookStore.AspNetCoreMvc.Context;
using BookStore.AspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.AspNetCoreMvc.Controllers
{
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult New()
        {
            CityViewModel model = new CityViewModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(CityViewModel model)
        {
            DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder<BookStoreDbContext>();
            dbContextOptionsBuilder.UseSqlServer();
            BookStoreDbContext bookStoreDbContext = new BookStoreDbContext();
            return null;
        }
    }
}
