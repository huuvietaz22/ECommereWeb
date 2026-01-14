using Microsoft.AspNetCore.Mvc;

namespace ECommereWeb.Controllers
{
    public class HangHoaController : Controller
    {
        public IActionResult Index(int? loai)
        {
            return View();
        }
    }
}
