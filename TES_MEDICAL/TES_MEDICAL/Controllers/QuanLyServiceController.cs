using Microsoft.AspNetCore.Mvc;

namespace TES_MEDICAL.Controllers
{
    public class QuanLyServiceController : Controller
    {
        public IActionResult ThemService()
        {
            return View();
        }
        public IActionResult XoaService()
        {
            return View();
        }
        public IActionResult SuaService()
        {
            return View();
        }
    }
}
