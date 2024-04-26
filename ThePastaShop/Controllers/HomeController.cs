using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ThePastaShop.Models;

namespace ThePastaShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var confirmatie = (string?)TempData["confirmatie"];
            if (confirmatie is null)
            {
                return View();
            }
            return View((object)confirmatie);
        }
    }
}
