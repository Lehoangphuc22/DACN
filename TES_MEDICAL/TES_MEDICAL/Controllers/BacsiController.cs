using Microsoft.AspNetCore.Mvc;

namespace TES_MEDICAL.Controllers
{
    public class BacsiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Lichsukham()
        {
            return View();
        }
    }
}
