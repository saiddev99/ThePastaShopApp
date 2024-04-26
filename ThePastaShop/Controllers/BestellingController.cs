using Microsoft.AspNetCore.Mvc;
using ThePastaShop.Models;

namespace ThePastaShop.Controllers
{
    public class BestellingController : Controller
    {
        public IActionResult Index()
        {
            PastaModel pasta = new PastaModel();
            return View(pasta);
        }
    }
}
