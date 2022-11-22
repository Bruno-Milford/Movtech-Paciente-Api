using Microsoft.AspNetCore.Mvc;

namespace HospitalApi.Controllers
{
    public class HospitalizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
