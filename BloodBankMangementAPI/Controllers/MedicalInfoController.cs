using Microsoft.AspNetCore.Mvc;

namespace BloodBankMangementAPI.Controllers
{
    public class MedicalInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
