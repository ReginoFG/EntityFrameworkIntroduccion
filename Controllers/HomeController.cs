using entityBasicoDAL;
using EntityFrameworkIntroduccion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntityFrameworkIntroduccion.Controllers
{
    public class HomeController : Controller
    {
        private readonly AccesoDC context;

        public HomeController(AccesoDC context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}