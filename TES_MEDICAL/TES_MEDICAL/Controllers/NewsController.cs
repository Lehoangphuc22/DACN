using Microsoft.AspNetCore.Mvc;

namespace TES_MEDICAL.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult TinYTe()
        {
            return View();
        }
        public IActionResult TinDichVu()
        {
            return View();
        }
        public IActionResult YHocThuongThuc()
        {
            return View();
        }
    }
}
