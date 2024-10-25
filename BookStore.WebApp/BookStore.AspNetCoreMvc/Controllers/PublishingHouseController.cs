using Microsoft.AspNetCore.Mvc;

namespace BookStore.AspNetCoreMvc.Controllers
{
    public class PublishingHouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
