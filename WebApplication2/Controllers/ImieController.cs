using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ImieController : Controller
    {
        public IActionResult Index()
        {
            var model = new Dane();
            model.Imie = "Aleksander";
            model.Nazwisko = "Skierka";
            return View(model);
        }
    }
}
