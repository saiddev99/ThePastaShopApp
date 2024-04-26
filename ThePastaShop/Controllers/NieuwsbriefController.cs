using Microsoft.AspNetCore.Mvc;
using ThePastaShop.Models;

namespace ThePastaShop.Controllers
{
    public class NieuwsbriefController : Controller
    {
        public IActionResult Index()
        {
            PersoonViewModel persoon = new PersoonViewModel();
            return View(persoon);
        }

        public IActionResult Confirmatie(PersoonViewModel persoon)
        {
            if (ModelState.IsValid)
            {
                return View(persoon);
            }
            else
            {
                return View(nameof(Index), persoon);
            }
        }
    }
}
