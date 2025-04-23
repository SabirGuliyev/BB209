

using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            return View();

            
        }
        public IActionResult Detail(int? id)
        {
            if (id is null || id < 1)
            {
                return RedirectToAction("Error");
            }
       

            return View("Shop");
        }

        public IActionResult Error()
        {
            return View();
        }








        [Route("korporativ-satislar")]
        public string CorporateSales()
        {
            return "Korparativ satishlar sehifesi";
        }

    }
}
