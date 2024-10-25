using BookStore.AspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
