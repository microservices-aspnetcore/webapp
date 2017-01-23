using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using webapp.Models;

namespace webapp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var model = new StockQuote { Symbol = "HLLO", Price = 3200 };

            return View(model);            
        }
    }
}
