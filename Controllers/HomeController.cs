using Microsoft.AspNetCore.Mvc;

namespace webapp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }
    }
}
