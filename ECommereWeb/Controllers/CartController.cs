using Microsoft.AspNetCore.Mvc;

namespace ECommereWeb.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
