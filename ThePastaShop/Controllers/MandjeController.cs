using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using ThePastaShop.Models;

namespace ThePastaShop.Controllers
{
    public class MandjeController : Controller
    {
        [HttpPost]
        public IActionResult Add(PastaModel? pasta)
        {
            List<PastaModel> pastas;

            if (HttpContext.Session.GetString("pasta") == null)
            {
                pastas = new List<PastaModel>();
            }
            else
            {
                pastas = JsonSerializer.Deserialize<List<PastaModel>?>(HttpContext.Session.GetString("pasta"));
            }
            pastas.Add(pasta);
            HttpContext.Session.SetString("pasta", JsonSerializer.Serialize(pastas));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("pasta") == null)
            {
                ViewBag.leeg = "Lege mandje";
                return View();
            }
            var sessionPasta = JsonSerializer.Deserialize<List<PastaModel>?>(HttpContext.Session.GetString("pasta"));
            return View(sessionPasta);
        }

        public IActionResult Confirmatie()
        {
            HttpContext.Session.Clear();
            TempData["confirmatie"] = "Bestelling doorgevoerd";
            return RedirectToAction("Index", "Home");
        }


    }
}
