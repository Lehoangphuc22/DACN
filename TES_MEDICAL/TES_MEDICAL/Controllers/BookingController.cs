using Microsoft.AspNetCore.Mvc;

namespace TES_MEDICAL.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult BookingBase()
        {
            return View();
        }
        public IActionResult BookingDoctor()
        {
            return View();
        }
        public IActionResult BookingVaccin()
        {
            return View();
        }
    }
}
