﻿using Microsoft.AspNetCore.Mvc;

namespace BookStore.AspNetCoreMvc.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
