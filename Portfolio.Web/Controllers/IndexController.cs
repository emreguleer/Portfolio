using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
