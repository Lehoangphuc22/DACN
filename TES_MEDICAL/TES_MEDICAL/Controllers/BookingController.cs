using Microsoft.AspNetCore.Mvc;

namespace TES_MEDICAL.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult BookingBase()
        {
            return View();
        }
    }
}
