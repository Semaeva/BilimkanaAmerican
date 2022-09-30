using BilimkanaAmerican.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BilimkanaAmerican.Controllers
{
    public class HomeController : Controller
    {

        ApplicationContext context;
        public HomeController(ApplicationContext context) { this.context = context; }

      /*  [Authorize(Roles ="Admin")]*/

        public async Task<IActionResult> Index()
        {
          return View(await context.Users.ToArrayAsync());

        }
    

    }
}